# Assignment 2 - Web API Controllers

This project contains three Web API controllers (J1, J2, and J3) for various tasks. Each controller serves a specific purpose and provides endpoints for accessing their functionality.

## J1 Controller

### Description

The J1 Controller calculates happiness based on input values and returns "Sad" or "Happy" depending on the calculated score.

### Usage

- **Endpoint:** `/api/J1/{S}/{M}/{L}`
- **HTTP Method:** GET
- **Example:** Making a GET request to `/api/J1/3/2/1` will return "Sad" because the calculated score is 10, which is not less than 10.

## J2 Controller

### Description

The J2 Controller calculates the time at which a balloon touches the ground based on the initial height and maximum time.

### Usage

- **Endpoint:** `/api/J2/CalculateBalloonLandingTime/{h}/{M}`
- **HTTP Method:** GET
- **Example:** Making a GET request to `/api/J2/CalculateBalloonLandingTime/100/10` will return "The balloon first touches ground at hour: 6" because the calculation shows that the balloon touches the ground after 6 hours when the initial height is 100 meters.

## J3 Controller

### Description

The J3 Controller calculates the length of a Sumac sequence based on the first two terms provided.

### Usage

- **Endpoint:** `/api/J3/CalculateSumacSequenceLength/{t1}/{t2}`
- **HTTP Method:** GET
- **Example:** Making a GET request to `/api/J3/CalculateSumacSequenceLength/120/71` will return 5 because the Sumac sequence starting with 120 and 71 is: 120, 71, 49, 22, 27, 5.

## Running the Project

- Clone this repository.
- Open the project in your preferred development environment (e.g., Visual Studio).
- Build and run the project.
- Access the API endpoints as described above.

## The Controller are in the Controllers folder
