# GitHub Actions Workflows for DataInk

## Azure Deployment Workflow

This workflow automates the build, test, and deployment of DataInk to Azure Web App.

### Workflow Triggers

- **Push to main branch**: Automatically builds and deploys changes
- **Pull requests to main**: Builds and tests changes without deployment
- **Manual trigger**: Available in GitHub Actions UI (workflow_dispatch)

### Environment Variables

- `DOTNET_VERSION`: .NET SDK version used for building (9.0.x)
- `AZURE_WEBAPP_NAME`: Name of the Azure Web App (default: dataink-webapp)
- `AZURE_RESOURCE_GROUP`: Resource Group in Azure (DataInkRg1)
- `WORKING_DIRECTORY`: Location of the source code (./src)
- `PUBLISH_DIRECTORY`: Location for published output (./publish)

### Required GitHub Secrets

To enable the CI/CD pipeline, add these secrets to your repository:

- `AZURE_WEBAPP_PUBLISH_PROFILE`: The publish profile from your Azure Web App
  - In Azure Portal: Web App > Overview > Get publish profile > Copy content
  - In GitHub Repository: Settings > Secrets > New repository secret

- `AZURE_WEBAPP_NAME`: (Optional) Override the default web app name

### Workflow Steps

#### Build Job:
1. Check out the code
2. Set up .NET SDK
3. Restore dependencies
4. Build the application
5. Run tests
6. Publish the application
7. Upload the published files as an artifact

#### Deploy Job:
1. Download the artifact
2. Deploy to Azure Web App
3. Output the deployed webapp URL

### Customizing the Workflow

To modify the workflow:
1. Edit the `.github/workflows/azure-deploy.yml` file
2. Commit and push your changes
3. The updated workflow will be used for future deployments