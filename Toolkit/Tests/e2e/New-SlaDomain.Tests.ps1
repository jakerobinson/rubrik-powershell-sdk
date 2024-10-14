<#
.SYNOPSIS
Run tests around sla domains
#>
BeforeAll {
  . "$PSScriptRoot\..\E2eTestInit.ps1"
}

# TODO: SPARK-234573 fix this test
return

Describe -Name 'New-SlaDomain Tests' -Tag 'Public' -Fixture{
    Context -Name 'Sla Creation' {
        It -Name 'Sla is created' -Test {
            $name="e2e-test-sla"
            $description="description"
            $snapshotSchedule=@{
              "yearly"=@{
                "basicSchedule"=@{
                  "frequency"=1
                  "retention"=1
                  "retentionUnit"="YEARS"}
                "dayOfYear"="LAST_DAY"
                "yearStartMonth"="JANUARY"
              }
            }
            $objectTypes = @("MANAGED_VOLUME_OBJECT_TYPE")
            $reply = New-SlaDomain -Name $name -Description $description -SnapshotSchedule $snapshotSchedule -ObjectTypes $objectTypes
            $id = $reply.Id
            # $success = Remove-SlaDomain -ID $id
            # $success| Should -Be $true
        }
    }
}
