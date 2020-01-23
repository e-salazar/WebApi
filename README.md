# WebApi

Docker

Build:
  docker build -t values:1 -f .\WebApi\Dockerfile .

Run:
  docker run -p 8000:8000 values:1
  
Test:
  http://localhost:8000/values
