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

This application is automatically deployed to Azure Web Apps using GitHub Actions. The CI/CD pipeline will build, test, and deploy the application whenever changes are pushed to the main branch.

### Required GitHub Secrets

To set up the deployment, configure the following secrets in your GitHub repository:

- `AZURE_WEBAPP_NAME`: The name of your Azure Web App
- `AZURE_WEBAPP_PUBLISH_PROFILE`: The publish profile XML from your Azure Web App

### How to get the Publish Profile

1. Go to the Azure Portal
2. Navigate to your Web App
3. Click on "Get publish profile" in the Overview page
4. Save the downloaded file
5. Add the contents of the file as a GitHub secret