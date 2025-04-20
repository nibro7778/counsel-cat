
# 🐱 Counsel Cat - ASP.NET Core Web API

Counsel Cat is a sample ASP.NET Core Web API application containerized using Docker and deployed on Kubernetes. This guide provides step-by-step instructions for running the app locally using Docker and Kubernetes (via Minikube), and deploying it using Helm.

---

## 🚀 Project Features

- ASP.NET Core 8.0
- Dockerized build
- Swagger UI for API testing
- Kubernetes deployment
- Local access via browser using Minikube service

---

## 🛠️ Prerequisites

Make sure you have the following installed:

- [.NET SDK](https://dotnet.microsoft.com/download)
- [Docker](https://www.docker.com/)
- [Minikube](https://minikube.sigs.k8s.io/docs/start/)
- [Kubectl](https://kubernetes.io/docs/tasks/tools/)
- [Helm](https://helm.sh/docs/intro/install/)

---

## 🧩 Folder Structure

```
CounselCat/
├── CounselCat/                # ASP.NET Core API project
├── Dockerfile                 # Docker build file
├── docker-compose.yml         # Local dev setup
├── helm/                      # Helm chart directory
│   ├── Chart.yaml
│   ├── values.yaml
│   └── templates/
│       ├── deployment.yaml
│       └── service.yaml
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

## 📦 Environment Variables Used

- `ASPNETCORE_ENVIRONMENT=Development`
- `ASPNETCORE_URLS=http://+:80`

These are defined in the Kubernetes `deployment.yaml`.

---

## 📚 Helpful Commands

```bash
# See running pods
kubectl get pods

# Describe a pod
kubectl describe pod <pod-name>

# Delete deployment and service
kubectl delete -f k8s/
```

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

## 📦 Helm Chart Info

- `Chart.yaml`: Contains metadata about the Helm chart.
- `values.yaml`: Defines default configuration values.
- `templates/`: Contains Kubernetes manifest templates for deployment and service.

---

## 🙌 Contribution

PRs welcome if you'd like to enhance this sample!

---

## 📄 License

MIT
