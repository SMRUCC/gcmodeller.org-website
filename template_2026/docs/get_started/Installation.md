# Installation

## .NET application development

Use the gcmodeller library for develop your bioinformatics software. Just install the gcmodeller via install nuget package from visual studio: [gcmodeller nuget packages](http://nuget.xieguigang.me:8848/?q=gcmodeller)

## Use Docker Image

```
docker pull xieguigang/gcmodeller-env:alpha-0.0.43
```

## Install in R# environment

```bash
# Download and install R# runtime
dpkg -i renv_1.0.0_amd64.deb
# and then install the gcmodeller package into the R# runtime system
R# --install.packages ./gcmodeller.zip
```