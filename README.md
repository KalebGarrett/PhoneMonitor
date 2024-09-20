# Phone Monitor

A desktop app that uses machine learning to detect if a user has their phone out during work. Phone Monitor is built using ML.NET for image analytics, with an integrated notification system to alert users when a phone is detected.

## Features

- **Phone Detection:** Detects the presence of a phone in the user's workspace using machine learning models.
- **Real-time Notifications:** Alerts users via desktop notifications when a phone is detected.
- **Image Analytics:** Analyzes webcam feed in real-time to identify the phone.

## Technologies Used
| Name | Description |
| ------------- | ------------- |
| **[ML.NET](https://github.com/dotnet/machinelearning)** | Core machine learning framework used for phone detection. |
| **[OpenCvSharp4](https://github.com/shimat/opencvsharp)** | For webcam feed handling and image processing. |
| **[Microsoft Toolkit Notifications](https://learn.microsoft.com/en-us/windows/communitytoolkit/notifications)** | Provides real-time desktop notifications. |

## Sample Project

This project is based on the [ML.NET Object Detection Sample](https://github.com/dotnet/machinelearning-samples/tree/main/samples/csharp/end-to-end-apps/ObjectDetection-Onnx) but has been customized and extended for this app.

## Future Improvements

This is the first version of the Phone Monitor app, and the model is still in its early stages, so detection accuracy may not yet be optimal. Future improvements will focus on enhancing detection accuracy and minimizing false positives.

## Download

**[Phone Monitor App](https://drive.google.com/drive/folders/1kwzoN1JZWbVvIdtDCghcexs1cvOzOJfJ?usp=sharing)**

## Stats
![Alt](https://repobeats.axiom.co/api/embed/2fd1c41410b87502978eb7096fbf9dee182a0101.svg "Repobeats analytics image")

## Screenshots

![image](/Documentation/Images/phone-detection.png)

![image](/Documentation/Images/notification.png)