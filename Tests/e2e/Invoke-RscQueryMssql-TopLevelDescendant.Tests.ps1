BeforeAll {
    . "$PSScriptRoot\..\E2eTestInit.ps1"
}
Describe -Name 'New-RscQueryMssql -Op TopLevelDescendants' -Fixture {
    It -Name 'PhysicalHost' -Test {
        $physicalHostFields =
        Get-RscType -Name PhysicalHost -InitialProperties @(
            "id", 
            "name", 
            "physicalChildConnection.id"
        )
        $physicalHostFields.PhysicalChildConnection.Nodes = 
        Get-RscType -Name MssqlInstance -InitialProperties ("Id", "Name")
        $fields = Get-RscType -Name MssqlTopLevelDescendantTypeConnection
        $fields.nodes = $physicalHostFields
        $sqlObjects = (New-RscQueryMssql -Op TopLevelDescendants -Field $fields).Invoke()
        $sqlObjects.nodes | Should -Not -BeNullOrEmpty
    }
}