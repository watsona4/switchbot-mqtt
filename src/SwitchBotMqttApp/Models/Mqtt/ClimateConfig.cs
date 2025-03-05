using Newtonsoft.Json;
using SwitchBotMqttApp.Models.HomeAssistant;

namespace SwitchBotMqttApp.Models.Mqtt;

public class ClimateConfig(
    DeviceMqtt device, string objectId, string? defaultValue, string commandTopic, string commandTemplate, string name
        , string? actionTemplate, string? actionTopic, string? currentHumidityTemplate, string? currentHumidityTopic, string? currentTemperatureTemplate
        , string? currentTemperatureTopic, string? fanModeCommandTemplate, string? fanModeCommandTopic, string? fanModeStateTemplate
        , string? fanModeStateTopic, string[]? fanModes, decimal? initial, decimal? maxHumidity, decimal? maxTemp, decimal? minHumidity, decimal? minTemp
        , string? modeCommandTemplate, string? modeCommandTopic, string? modeStateTemplate, string? modeStateTopic, string[]? modes, string? payloadOff
        , string? payloadOn, string? powerCommandTemplate, string? powerCommandTopic, decimal? precision, string? presetModeCommandTemplate
        , string? presetModeCommandTopic, string? presetModeStateTopic, string? presetModeValueTemplate, string[]? presetModes
        , string? swingHorizontalModeCommandTemplate, string? swingHorizontalModeCommandTopic, string? swingHorizontalModeStateTemplate
        , string? swingHorizontalModeStateTopic, string[]? swingHorizontalModes, string? swingModeCommandTemplate, string? swingModeCommandTopic
        , string? swingModeStateTemplate, string? swingModeStateTopic, string[]? swingModes, string? targetHumidityCommandTemplate
        , string? targetHumidityCommandTopic, string? targetHumidityStateTopic, string? targetHumidityStateTemplate, string? temperatureCommandTemplate
        , string? temperatureCommandTopic, string? temperatureHighCommandTemplate, string? temperatureHighCommandTopic, string? temperatureHighStateTemplate
        , string? temperatureHighStateTopic, string? temperatureLowCommandTemplate, string? temperatureLowCommandTopic, string? temperatureLowStateTemplate
        , string? temperatureLowStateTopic, string? temperatureStateTemplate, string? temperatureStateTopic, string? temperatureUnit, decimal? tempStep) : MqttControlBase(
        topic: $"homeassistant/climate/{objectId}/config"
            , defaultValue: defaultValue 
            , commandTopic: commandTopic
            , commandTemplate: commandTemplate
            , name: name
            , uniqueId: objectId
            , objectId: objectId
            , device: device
            , deviceClass: null
            , icon: null)
{
    [JsonProperty("action_template")]
    public string? ActionTemplate { get; set; } = actionTemplate;

    [JsonProperty("action_topic")]
    public string? ActionTopic { get; set; } = actionTopic;

    [JsonProperty("current_humidity_template")]
    public string? CurrentHumidityTemplate { get; set; } = currentHumidityTemplate;

    [JsonProperty("current_humidity_topic")]
    public string? CurrentHumidityTopic { get; set; } = currentHumidityTopic;

    [JsonProperty("current_temperature_template")]
    public string? CurrentTemperatureTemplate { get; set; } = currentTemperatureTemplate;

    [JsonProperty("current_temperature_topic")]
    public string? CurrentTemperatureTopic { get; set; } = currentTemperatureTopic;

    [JsonProperty("fan_mode_command_template")]
    public string? FanModeCommandTemplate { get; set; } = fanModeCommandTemplate;

    [JsonProperty("fan_mode_command_topic")]
    public string? FanModeCommandTopic { get; set; } = fanModeCommandTopic;

    [JsonProperty("fan_mode_state_template")]
    public string? FanModeStateTemplate { get; set; } = fanModeStateTemplate;

    [JsonProperty("fan_mode_state_topic")]
    public string? FanModeStateTopic { get; set; } = fanModeStateTopic;

    [JsonProperty("fan_modes")]
    public string[]? FanModes { get; set; } = fanModes;

    [JsonProperty("initial")]
    public decimal? Initial { get; set; } = initial;

    [JsonProperty("max_humidity")]
    public decimal? MaxHumidity { get; set; } = maxHumidity;

    [JsonProperty("max_temp")]
    public decimal? MaxTemp { get; set; } = maxTemp;

    [JsonProperty("min_humidity")]
    public decimal? MinHumidity { get; set; } = minHumidity;

    [JsonProperty("min_temp")]
    public decimal? MinTemp { get; set; } = minTemp;

    [JsonProperty("mode_command_template")]
    public string? ModeCommandTemplate { get; set; } = modeCommandTemplate;

    [JsonProperty("mode_command_topic")]
    public string? ModeCommandTopic { get; set; } = modeCommandTopic;

    [JsonProperty("mode_state_template")]
    public string? ModeStateTemplate { get; set; } = modeStateTemplate;

    [JsonProperty("mode_state_topic")]
    public string? ModeStateTopic { get; set; } = modeStateTopic;

    [JsonProperty("modes")]
    public string[]? Modes { get; set; } = modes;

    [JsonProperty("payload_off")]
    public string? PayloadOff { get; set; } = payloadOff;

    [JsonProperty("payload_on")]
    public string? PayloadOn { get; set; } = payloadOn;

    [JsonProperty("power_command_template")]
    public string? PowerCommandTemplate { get; set; } = powerCommandTemplate;

    [JsonProperty("power_command_topic")]
    public string? PowerCommandTopic { get; set; } = powerCommandTopic;

    [JsonProperty("precision")]
    public decimal? Precision { get; set; } = precision;

    [JsonProperty("preset_mode_command_template")]
    public string? PresetModeCommandTemplate { get; set; } = presetModeCommandTemplate;

    [JsonProperty("preset_mode_command_topic")]
    public string? PresetModeCommandTopic { get; set; } = presetModeCommandTopic;

    [JsonProperty("preset_mode_state_topic")]
    public string? PresetModeStateTopic { get; set; } = presetModeStateTopic;

    [JsonProperty("preset_mode_value_template")]
    public string? PresetModeValueTemplate { get; set; } = presetModeValueTemplate;

    [JsonProperty("preset_modes")]
    public string[]? PresetModes { get; set; } = presetModes;

    [JsonProperty("swing_horizontal_mode_command_template")]
    public string? SwingHorizontalModeCommandTemplate { get; set; } = swingHorizontalModeCommandTemplate;

    [JsonProperty("swing_horizontal_mode_command_topic")]
    public string? SwingHorizontalModeCommandTopic { get; set; } = swingHorizontalModeCommandTopic;

    [JsonProperty("swing_horizontal_mode_state_template")]
    public string? SwingHorizontalModeStateTemplate { get; set; } = swingHorizontalModeStateTemplate;

    [JsonProperty("swing_horizontal_mode_state_topic")]
    public string? SwingHorizontalModeStateTopic { get; set; } = swingHorizontalModeStateTopic;

    [JsonProperty("swing_horizontal_modes")]
    public string[]? SwingHorizontalModes { get; set; } = swingHorizontalModes;

    [JsonProperty("swing_mode_command_template")]
    public string? SwingModeCommandTemplate { get; set; } = swingModeCommandTemplate;

    [JsonProperty("swing_mode_command_topic")]
    public string? SwingModeCommandTopic { get; set; } = swingModeCommandTopic;

    [JsonProperty("swing_mode_state_template")]
    public string? SwingModeStateTemplate { get; set; } = swingModeStateTemplate;

    [JsonProperty("swing_mode_state_topic")]
    public string? SwingModeStateTopic { get; set; } = swingModeStateTopic;

    [JsonProperty("swing_modes")]
    public string[]? SwingModes { get; set; } = swingModes;

    [JsonProperty("target_humidity_command_template")]
    public string? TargetHumidityCommandTemplate { get; set; } = targetHumidityCommandTemplate;

    [JsonProperty("target_humidity_command_topic")]
    public string? TargetHumidityCommandTopic { get; set; } = targetHumidityCommandTopic;

    [JsonProperty("target_humidity_state_topic")]
    public string? TargetHumidityStateTopic { get; set; } = targetHumidityStateTopic;

    [JsonProperty("target_humidity_state_template")]
    public string? TargetHumidityStateTemplate { get; set; } = targetHumidityStateTemplate;

    [JsonProperty("temperature_command_template")]
    public string? TemperatureCommandTemplate { get; set; } = temperatureCommandTemplate;

    [JsonProperty("temperature_command_topic")]
    public string? TemperatureCommandTopic { get; set; } = temperatureCommandTopic;

    [JsonProperty("temperature_high_command_template")]
    public string? TemperatureHighCommandTemplate { get; set; } = temperatureHighCommandTemplate;

    [JsonProperty("temperature_high_command_topic")]
    public string? TemperatureHighCommandTopic { get; set; } = temperatureHighCommandTopic;

    [JsonProperty("temperature_high_state_template")]
    public string? TemperatureHighStateTemplate { get; set; } = temperatureHighStateTemplate;

    [JsonProperty("temperature_high_state_topic")]
    public string? TemperatureHighStateTopic { get; set; } = temperatureHighStateTopic;

    [JsonProperty("temperature_low_command_template")]
    public string? TemperatureLowCommandTemplate { get; set; } = temperatureLowCommandTemplate;

    [JsonProperty("temperature_low_command_topic")]
    public string? TemperatureLowCommandTopic { get; set; } = temperatureLowCommandTopic;

    [JsonProperty("temperature_low_state_template")]
    public string? TemperatureLowStateTemplate { get; set; } = temperatureLowStateTemplate;

    [JsonProperty("temperature_low_state_topic")]
    public string? TemperatureLowStateTopic { get; set; } = temperatureLowStateTopic;

    [JsonProperty("temperature_state_template")]
    public string? TemperatureStateTemplate { get; set; } = temperatureStateTemplate;

    [JsonProperty("temperature_state_topic")]
    public string? TemperatureStateTopic { get; set; } = temperatureStateTopic;

    [JsonProperty("temperature_unit")]
    public string? TemperatureUnit { get; set; } = temperatureUnit;

    [JsonProperty("temp_step")]
    public decimal? TempStep { get; set; } = tempStep;
}