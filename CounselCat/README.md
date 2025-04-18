
# 🐱 Counsel Cat - ASP.NET Core Web API

This is a sample ASP.NET Core 8.0 Web API project called **Counsel Cat**, containerized using Docker and deployed to a local Kubernetes cluster using **Minikube**.

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

- [Docker](https://www.docker.com/products/docker-desktop/)
- [Minikube](https://minikube.sigs.k8s.io/docs/start/)
- [kubectl](https://kubernetes.io/docs/tasks/tools/)
- [.NET SDK 8.0](https://dotnet.microsoft.com/en-us/download)

---

## 🧩 Folder Structure

```
.
├── CounselCat/                  # ASP.NET Core Web API source
├── Dockerfile                   # Docker build definition
├── docker-compose.yml           # Optional local run using Compose
├── k8s/
│   ├── deployment.yaml          # Kubernetes deployment
│   └── service.yaml             # Kubernetes service
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

### 1. Start Minikube

```bash
minikube start
```

### 2. Point Docker to Minikube's Docker Daemon

```bash
eval $(minikube -p minikube docker-env)
```

### 3. Build Docker Image Inside Minikube

```bash
docker build -t counsel-cat:latest .
```

### 4. Switch Back to Host Docker (Optional)

```bash
eval $(minikube -p minikube docker-env -u)
```

### 5. Apply Kubernetes Deployment & Service

```bash
kubectl apply -f k8s/deployment.yaml
kubectl apply -f k8s/service.yaml
```

### 6. Access the App via Browser

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

```bash
minikube stop
minikube delete
```

---

## 🙌 Contribution

PRs welcome if you'd like to enhance this sample!

---

## 📄 License

MIT
