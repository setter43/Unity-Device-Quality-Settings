// Set the quality settings based on the device's specifications
if (SystemInfo.deviceType == DeviceType.Desktop) {
    QualitySettings.SetQualityLevel(0); // High quality settings for desktop devices
} else 
if (SystemInfo.deviceType == DeviceType.Handheld) {
    if (SystemInfo.deviceName == "RK3588") {
        QualitySettings.SetQualityLevel(3588); // Custom quality settings for RK3588 devices
    } else {
        QualitySettings.SetQualityLevel(1); // Low quality settings for mobile devices
    }
} else {
    QualitySettings.SetQualityLevel(2); // Low quality sby defualt if device is not identified
}
