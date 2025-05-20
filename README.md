# DataInk™ – Where Data Meets Design

## Unleash the Power of Visual Intelligence

DataInk™ is the revolutionary platform that transforms raw data into stunning, story-driven visuals with just a few clicks. Designed for analysts, marketers, educators, and innovators, DataInk bridges the gap between complex datasets and compelling narratives.

Key Features:

🎨 Smart Visualization Engine – Automatically selects the most impactful chart or graphic for your data.
🧠 AI-Powered Insights – Detects trends, anomalies, and correlations in real time.
🔗 Seamless Integration – Connects effortlessly with Excel, SQL, cloud storage, and over 50 data sources.
🖋️ Custom Design Studio – Fine-tune every pixel with intuitive drag-and-drop tools and brand-ready templates.
🔒 Enterprise-Grade Security – Your data stays yours, protected by end-to-end encryption.

Why DataInk?
Because data deserves more than spreadsheets. Whether you're pitching to stakeholders or teaching a classroom, DataInk helps you paint with information—turning numbers into narratives and insights into impact.

## Deployment

DataInk is automatically deployed to Azure using GitHub Actions. The workflow performs:
- Building and testing of the application
- Deployment to Azure Web App in the DataInkRg1 resource group

### Required GitHub Secrets

To enable the CI/CD pipeline, add these secrets to your repository:
- `AZURE_WEBAPP_PUBLISH_PROFILE`: The publish profile from your Azure Web App
- `AZURE_WEBAPP_NAME`: (Optional) The name of your Azure Web App (default: dataink-webapp)

For more details, see the workflow file in `.github/workflows/azure-deploy.yml`.