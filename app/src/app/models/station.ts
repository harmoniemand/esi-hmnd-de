import { Sensor } from './sensor';

export class Station {
    public SensorStationId: string;
    public Lat: number;
    public Long: number;
    public BatteryLevel: number;

    public Sensors: Sensor[] = [];
}
