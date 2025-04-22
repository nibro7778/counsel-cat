terraform {
  backend "s3" {
    bucket         = "counsel-cat-terraform-state-bucket"
    key            = "terraform.tfstate"
    region         = "ap-southeast-2"
    use_lockfile = true
    encrypt        = true
  }
}