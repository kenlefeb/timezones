using Pulumi;
using Pulumi.Azure.Core;
using Pulumi.Azure.Storage;

class MyStack : Stack
{
    public MyStack()
    {
        var environment = System.Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? string.Empty;

        // Create an Azure Resource Group
        var @group = new ResourceGroup(EnvironmentName("timezones", environment));

        // Create an Azure Storage Account
        var storage = new Account("timezones", new AccountArgs
        {
            ResourceGroupName = @group.Name,
            AccountReplicationType = "LRS",
            AccountTier = "Standard"
        });

        // Export the connection string for the storage account
        this.ConnectionString = storage.PrimaryConnectionString;


    }

    private string EnvironmentName(string name, string? environment = null)
    {

	    return string.IsNullOrEmpty(environment)
		    ? name
		    : $"{name}-{environment}";

    }

    [Output]
    public Output<string> ConnectionString { get; set; }
}
