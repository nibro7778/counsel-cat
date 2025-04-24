
# 🐱 Counsel Cat - ASP.NET Core Web API

This project is a sample .NET 8 Web API application containerized with Docker, deployed using Kubernetes via Helm, and provisioned with infrastructure on AWS using Terraform.

---

## 🚀 Project Features

- ASP.NET Core 8.0
- Dockerized build
- Kubernetes deployment 
- AWS (S3, DynamoDB, ECR, EKS)
- Github Actions (CI/CD)

---

## 🛠️ Prerequisites

Make sure you have the following installed:

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)
- [Docker](https://docs.docker.com/get-docker/)
- [Minikube](https://minikube.sigs.k8s.io/docs/start/)
- [Kubectl](https://kubernetes.io/docs/tasks/tools/)
- [Helm](https://helm.sh/docs/intro/install/)
- [Terraform](https://developer.hashicorp.com/terraform/install)
- [AWS CLI](https://docs.aws.amazon.com/cli/latest/userguide/install-cliv2.html) (Configured with credentials)
---

## 🧩 Folder Structure

```
CounselCat/
├── CounselCat/               # .NET Web API project
├── infra/                    # Terraform infrastructure code
│   ├── main.tf
│   ├── variables.tf
│   ├── backend.tf
│   ├── provider.tf
│   └── modules/
│       └── ecr/
│           ├── main.tf
│           └── variables.tf
├── helm/                     # Helm chart for Kubernetes deployment
│   ├── Chart.yaml
│   ├── values.yaml
│   └── templates/
│       ├── deployment.yaml
│       └── service.yaml
|
|── .github/workflows/       # GitHub Actions CI/CD pipelines
|   ├── app-cicd.yaml
|   └── infra-cicd.yaml
└── README.md
```

---

## 🧪 Run Locally (Optional)

### Using Docker Compose

```bash
docker-compose up --build --no-cache
```

Visit: [http://localhost:8080/swagger/index.html](http://localhost:8080/swagger/index.html)

---

## 🚢 Deploy to Kubernetes (Minikube)

1. **Start Minikube:**
   ```bash
   minikube start
   eval $(minikube -p minikube docker-env)
   ```

2. **Build Docker image in Minikube Docker daemon:**
   ```bash
   docker build -t counsel-cat:latest .
   ```

3. **Deploy with Helm:**
   ```bash
   helm install counsel-cat ./helm
   ```

4. **Expose the service:**
   ```bash
   minikube service counsel-cat-service
   ```

> This will open your browser to the exposed service. You should see the Swagger UI.

---
## 🧼 Cleanup

To delete Helm release and cleanup Kubernetes resources:

```bash
helm uninstall counsel-cat
```

To delete everything in default namespace:

```bash
kubectl delete all --all
```
---

## ☁️ Cloud Infrastructure Overview

Provisioned using Terraform:

- Amazon ECR for container images
- Amazon S3, DynamoDB for Terraform state storage
- (Optional) VPC, EKS, IAM roles, and more...

---

## 🔐 AWS Requirements

Before running Terraform:

- Install and configure AWS CLI
- Ensure you have:
  - An S3 bucket: `counsel-cat-terraform-state-bucket` and A DynamoDB table `terraform-locks` for locking
  - IAM user or role with appropriate permissions
---

## 📦 Terraform Commands

```bash
cd infra/

# Initialize Terraform
terraform init

# Apply infrastructure changes
terraform apply
```
---

## 🙌 Contribution

PRs welcome if you'd like to enhance this sample!

---

## 📄 License

MIT
