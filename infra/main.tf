module "ecr" {
  source = "./modules/ecr"
  repository_name = var.ecr_repo_name
}

module "eks" {
  source        = "./modules/eks"
  cluster_name  = "counsel-cat-cluster"
  vpc_id        = module.vpc.vpc_id
  subnet_ids    = module.vpc.public_subnets
}
