FROM microsoft/dotnet:1.1.0-sdk-projectjson

# Create directory for the app source code
RUN mkdir -p /usr/src/sampleWebApiNetCore
WORKDIR /usr/src/sampleWebApiNetCore

# Copy the source and restore dependencies
COPY . /usr/src/sampleWebApiNetCore
RUN dotnet restore

# Expose the port and start the app
EXPOSE 5000
CMD [ "dotnet", "run" ]