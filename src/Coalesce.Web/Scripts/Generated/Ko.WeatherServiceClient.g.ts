
/// <reference path="../coalesce.dependencies.d.ts" />

// Knockout List View Model for: IWeatherService
// Generated by IntelliTect.Coalesce

module Services {
    export class WeatherServiceClient {
        public readonly apiController: string = "/IWeatherService";

        public static coalesceConfig = new Coalesce.ServiceClientConfiguration<WeatherServiceClient>(Coalesce.GlobalConfiguration.serviceClient);
        public coalesceConfig: Coalesce.ServiceClientConfiguration<WeatherServiceClient>
            = new Coalesce.ServiceClientConfiguration<WeatherServiceClient>(WeatherServiceClient.coalesceConfig);

        
        /**
            Methods and properties for invoking server method GetWeather.
        */
        public readonly getWeather = new WeatherServiceClient.GetWeather(this);
        public static GetWeather = class GetWeather extends Coalesce.ClientMethod<WeatherServiceClient, ViewModels.WeatherData> {
            public readonly name = 'GetWeather';
            public readonly verb = 'POST';
            
            /** Calls server method (GetWeather) with the given arguments */
            public invoke = (callback: (result: ViewModels.WeatherData) => void = null, reload: boolean = true): JQueryPromise<any> => {
                return this.invokeWithData({  }, callback);
            };
            
            protected loadResponse = (data: any, callback?: (result: ViewModels.WeatherData) => void, reload?: boolean) => {
                if (!this.result()) {
                    this.result(new ViewModels.WeatherData(data));
                } else {
                    this.result().loadFromDto(data);
                }
                if (typeof(callback) == 'function')
                    callback(this.result());
            };
        };
    }
}