terraform {
  backend "s3" {
    bucket         = "counsel-cat-terraform-state-bucket"
    key            = "terraform.tfstate"
    region         = "ap-southeast-2"
    dynamodb_table = "terraform-locks"    # DynamoDB table to use for state locking
    acl            = "bucket-owner-full-control" # S3 ACL (adjust as needed)
    encrypt        = true
  }
}