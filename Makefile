DOTNET := /usr/bin/dotnet
PROJECT := WebApi.csproj

.PHONY: run watch build clean

run:
	$(DOTNET) run --project $(PROJECT)

watch:
	$(DOTNET) watch --project $(PROJECT)

build:
	$(DOTNET) build $(PROJECT)

clean:
	$(DOTNET) clean $(PROJECT)
