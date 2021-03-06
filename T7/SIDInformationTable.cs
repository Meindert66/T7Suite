using System;
using System.Collections.Generic;
using System.Text;

namespace T7
{
    class SIDInformationTable
    {
        public SIDICollection GetSIDInformation()
        {
            SIDICollection _collection = new SIDICollection();
            AddSIDIHelper(_collection, "Rpm ", "In.n_Engine", "Engine speed UNIT : rpm MAX : 8000 MIN : 25 (set to 10 when engine starts to move) TRANS : V = P. Resolution is 1. Interval is Every combustion / 5 ms when engine is still.", 0);
            AddSIDIHelper(_collection, "Lamb", "Lambda.LambdaInt", "Global closed loop integrator. Update : every combustion. V6: Bank 1. Resolution is ° 0.01 %.", 0);
            AddSIDIHelper(_collection, "STAd", "E85Adap.ST_Adap", "", 0);
            AddSIDIHelper(_collection, "Tair", "In.T_AirInlet", "Inlet air temperature UNIT : (C MAX : 140 MIN : -40 TRANS : V = P. Resolution is 1. Interval is 1000 ms.", 0);
            AddSIDIHelper(_collection, "Meng", "Out.M_Engine", "Engine torque UNIT : Nm MAX : 400 MIN : -100 TRANS : V = (P+. Resolution is 1. Interval is 10ms.", 0);
            AddSIDIHelper(_collection, "Mlow", "TorqueProt.M_LowLim", "By the Torque Master selected lowest torque limit request, corrected with adaption value made at idle.", 0);
            AddSIDIHelper(_collection, "nErr", "obdNoOfFaults", "Number of errors stored", 0);
            AddSIDIHelper(_collection, "Pair", "In.p_AirAmbient", "Barometric air pressure UNIT : kPa MAX : 120 MIN : 50 TRANS : V = P * 10. Resolution is 0.1. Interval is 250 ms.", 0);
            AddSIDIHelper(_collection, "mAIR", "MAF.m_AirInlet", "Airmass in milligram per combustion. This airmass is the actual load value in the ECM. (Unfiltered) Calculated from ActualIn.Q_AirInlet. Resolution is 1 mg/c. Interval is every combustion.", 0);
            AddSIDIHelper(_collection, "Me85", "In.X_EthanolSensor,", "", 0);
            AddSIDIHelper(_collection, "Ad85", "E85.X_EthanolActual", "", 0);
            AddSIDIHelper(_collection, "Ca85", "E85Prot.X_EthanolActual", "", 0);
            AddSIDIHelper(_collection, "Amul", "AdpFuelProt.MulFuelAdapt", "Multicative fueladaption value. Resolution is ° 0.01 %.", 0);
            AddSIDIHelper(_collection, "FFac", "Purge.FuelFac", "The fuelfactor from the purge function. Resolution is 0.01 %.", 0);
            AddSIDIHelper(_collection, "ReFu", "E85Adap.ST_ReFuel", "", 0);
            AddSIDIHelper(_collection, "Crnk", "CrnkCas.ST_Fuel", "", 0);
            AddSIDIHelper(_collection, "MxLo", "LambdaProt.MaxLoadNorm", "Max load (airmass) for closed loop during normal conditions. Update : every combustion. Resolution is 1 mg/c.", 0);
            AddSIDIHelper(_collection, "SFuL", "E85Adap.V_SavedFuelLevel", "", 0);
            AddSIDIHelper(_collection, "VFue", "In.V_FuelTank", "Fuel level UNIT : l (litre) MAX : 100 MIN : 0 TRANS : V = P * 10. Resolution is 0.1. Interval is 1000 ms.", 0);
            AddSIDIHelper(_collection, "Aadd", "AdpFuelProt.AddFuelAdapt", "Additative fueladaption value. Resolution is 0.01 mg/c.", 0);
            AddSIDIHelper(_collection, "Aadp", "AreaAdap.A_Throttle", "Adaption of throttle area. Interval is 250ms.", 0);
            AddSIDIHelper(_collection, "AdpD", "IdleAdap.Q_AirDrive", "Adaption value for idlespeed regulation (drive activated). This value is added to the PID and Constant part of the regulator. If the I-part is limited will the adaption stop. Resolution is 0.01 g/s.", 0);
            AddSIDIHelper(_collection, "AdpN", "IdleAdap.Q_AirNeutral", "Adaption value for idlespeed regulation (drive not activated). This value is added to the PID and Constant part of the regulator. If the I-part is limited will the adaption stop. Resolution is 0.01 g/s.", 0);
            AddSIDIHelper(_collection, "Akw1", "KnkAdaptAdap.RefValueWind", "", 0);
            AddSIDIHelper(_collection, "Akw2", "KnkAdaptAdap.RefValueWin+2", "", 0);
            AddSIDIHelper(_collection, "AMR ", "CanIn.ST_EngineInterv", "Engine intervention is requested from ESP (AMR)", 0);
            AddSIDIHelper(_collection, "Apur", "Purge.HCCont", "The content of HC in the purge air. Resolution is 0.1 %.", 0);
            AddSIDIHelper(_collection, "ay  ", "CanIn.a_Lateral", "Lateral acceleration, only implemented on cars with ESP. Resolution is 0.5 m/s2.", 0);
            AddSIDIHelper(_collection, "BMR ", "CanIn.ST_BrakeInterv", "Brake intervention is requested from ESP (BMR)", 0);
            AddSIDIHelper(_collection, "CLUi", "Out.CMD_CoastLUInhibit", "Inhibit coast slip lock up", 0);
            AddSIDIHelper(_collection, "Cmem", "EngTip.ST_Active", "Status flag showing if tipin is active 0 = Not active 1 = Tip-in active 2 = Tip-out active", 0);
            AddSIDIHelper(_collection, "CSLU", "In.ST_TCMCSLU", "Coast Lock up slip state 0 = No request 1 = Fuel cut inhibit 2 = Fuel cut allowed", 0);
            AddSIDIHelper(_collection, "DTI ", "Out.M_DTI", "Drivers Torque Intention. The torque that the driver requests converted from air to torque. Limitations from all functions excluding TCM and TCS are included in the signal UNIT : Nm MAX : 400 MIN : -100", 0);
            AddSIDIHelper(_collection, "Fcod", "obdFaults", "codes for errors stored", 0);
            AddSIDIHelper(_collection, "FFAd", "Purge.m_FuelPrg", "Fuel flow from purge. Resolution is 0.01 mg/c.", 0);
            AddSIDIHelper(_collection, "Flow", "Purge.Flow", "The actual purge flow. Resolution is 1 mg/s.", 0);
            AddSIDIHelper(_collection, "FMXF", "PurgeProt.FuelFacMaxFlow", "Maximum allowed purge flow in respect to maximum allowed fuel factor at actual load. Resolution is 1 mg/s.", 0);
            AddSIDIHelper(_collection, "Frez", "PurgeProt.AdpFreeze", "Adaption freeze status.", 0);
            AddSIDIHelper(_collection, "Fuel", "BFuelProt.CurrentFuelCons", "", 0);
            AddSIDIHelper(_collection, "Gear", "In.X_ActualGear", "Actual gear on automatic gearbox. 2 - Reverse 3 - Neutral 5 - Gear 1 6 - Gear 2 7 - Gear 3 8 - Gear 4 11 - Gear 3, lock up 12 - Gear 4, lock up Interval is every 50 ms.", 0);
            AddSIDIHelper(_collection, "GSI ", "Out.CMD_GearShiftInhibit", "Prevent TCM from shifting.", 0);
            AddSIDIHelper(_collection, "HCnt", "Purge.HCCont", "The content of HC in the purge air. Resolution is 0.1 %.", 0);
            AddSIDIHelper(_collection, "In.X", "In.X_AccPedal", "Pedal position UNIT : % MAX : 130 MIN : 0 TRANS : V = P * 10. Resolution is 0.1. Interval is 20 ms.", 0);
            AddSIDIHelper(_collection, "Iput", "ActualIn.n_GearBoxIn", "Transmission input rpm (turbine speed) Used to detect when the load is changed for the engine when gear is engaged. Resolution is 1 rpm. Interval is every 50 ms.", 0);
            AddSIDIHelper(_collection, "JeLi", "JerkProt.JerkFactor", "Threshold value for changing shift pattern to no lockup", 0);
            AddSIDIHelper(_collection, "Jerk", "ECMStat.JerkFactor", "This factor describes the jerking of the engine. The formula for calculating this is abs(ECMStat.n_EngineDelta2) * factor. The factor is for scaling it so it will be possible to filter it. The calibratable value used for filtering is nEngCal.FilterFactor. Since the jerk factor is based on every combustion, it is not possible to compare the numbers for 6 cylinder engines and 4 cylinder.", 0);
            AddSIDIHelper(_collection, "Kph1", "ActualIn.v_Vehicle", "Left front wheel speed UNIT : km/h MAX : 300 MIN : 0 (detection of min. 1.0 km/h) TRANS : V = P * 10. Resolution is 0.1. Interval is 100 ms.", 0);
            AddSIDIHelper(_collection, "Kph2", "ActualIn.v_Vehicle2", "Vehicle speed, measured on the rear wheel, sent from MIU. UNIT : km/h MAX : 300 MIN : 0 TRANS : V = P * 10. Resolution is 0.1. Interval is 100 ms", 0);
            AddSIDIHelper(_collection, "LwsI", "CanIn.fi_SteeringAngle", "Stearing angle (LwsIn), only implemented on cars with ESP . Resolution is 3 °.", 0);
            AddSIDIHelper(_collection, "mAir", "MAF.m_AirInlet", "Airmass in milligram per combustion. This airmass is the actual load value in the ECM. (Unfiltered) Calculated from ActualIn.Q_AirInlet. Resolution is 1 mg/c. Interval is every combustion.", 0);
            AddSIDIHelper(_collection, "Mair", "In.M_TCSTorqueReq", "Maximum torque request from TCS system via CAN. Resolution is 1 Nm. Interval is Every 20 ms.", 0);
            AddSIDIHelper(_collection, "MiFi", "Missf.nrOfFilteredMisfire", "Number of missfires occurred", 0);
            AddSIDIHelper(_collection, "Mnom", "Torque.M_Nominal", "Nominal engine output torque at a certain enginespeed and inlet airmass. Read from matrix.", 0);
            AddSIDIHelper(_collection, "MTCM", "ActualIn.M_TCMLimitReq", "Maximum engine torque request from TCM UNIT : Nm MAX : 400 MIN : -100 TRANS : V = P. Resolution is 1. Interval is 10 ms.", 0);
            AddSIDIHelper(_collection, "Mtot", "In.M_TCSTotalReq", "Total torque request from ESP equiped cars. The differance in torque between In.M_TCSTorqueReq and In.M_TCSTotalReq is taken with ignition retardation. Resolution is 1 Nm. Interval is Every 20 ms.", 0);
            AddSIDIHelper(_collection, "NoIg", "Out.ST_NoIgnitionRetard", "Ignition retardation is not allowed due to overheating the catalytic converter", 0);
            AddSIDIHelper(_collection, "Oput", "DiffPSProt.v_GearBoxOut", "TCM gearbox output speed converted to vehicle speed. Resolution is 0.1 km/h. Interval is Every 100ms", 0);
            AddSIDIHelper(_collection, "Pdif", "ECMStat.p_Diff", "Differance between inlet manifold air pressure and external air pressure. Resolution is 0.1 kPa.", 0);
            AddSIDIHelper(_collection, "Peng", "ECMStat.P_Engine", "Calculated engine power. Measured in horsepower.", 0);
            AddSIDIHelper(_collection, "Perc", "PurgeProt.PurgePercent", "Purge flow/Air mass flow ratio. Resolution is 0.01 %.", 0);
            AddSIDIHelper(_collection, "PMXF", "PurgeProt.PdiffMaxFlow", "Maximum flow allowed by the diff. pressure. Resolution is 1 mg/s.", 0);
            AddSIDIHelper(_collection, "Ppwm", "Purge.Valve", "Purge valve PWM. Resolution is 0.1 %.", 0);
            AddSIDIHelper(_collection, "PrSt", "Purge.Status", "Status of the purge function.", 0);
            AddSIDIHelper(_collection, "ReqF", "PurgeProt.ReqFlow", "Requested purge flow. Resolution is 1 mg/s.", 0);
            AddSIDIHelper(_collection, "ShPn", "In.ST_TCMShiftPattern", "Active TCM shift pattern 0 = ECO 1 = Pwr 2 = Wusp 3 = Wnt 4 = US1 5 = US2 6 = Hot1 7 = Hot2 8 = Jerk 9 = Rep 10 = DS 11 = Tap U/D", 0);
            AddSIDIHelper(_collection, "Tign", "TorqueCal.T_NoIgnRet", "No retardation of ignition above this exhaust temperature", 0);
            AddSIDIHelper(_collection, "Tlmp", "unknown", "", 0);
            AddSIDIHelper(_collection, "TngA", "ActualIn.T_Engine", "Engine coolant temperature UNIT : (C MAX : 150 MIN : -40 TRANS : V = P. Resolution is 1. Interval is 1000 ms.", 0);
            AddSIDIHelper(_collection, "TTCM", "In.T_TCMOil", "Oil temperature in automatic gearbox", 0);
            AddSIDIHelper(_collection, "tTCM", "In.t_TCMTrqLimDuration", "Maximum engine torque duration UNIT : ms MAX : 2500 MIN : 0 TRANS : V = P. Resolution is 1. Interval is 10 ms.", 0);
            AddSIDIHelper(_collection, "vGiF", "CanIn.fi_YawVelocity", "Yaw velocity (vGiF), only implemented on cars with ESP. Resolution is 0.02 °.", 0);
            AddSIDIHelper(_collection, "vVLF", "In.v_Vehicle", "Left front wheel speed UNIT : km/h MAX : 300 MIN : 0 (detection of min. 1.0 km/h) TRANS : V = P * 10. Resolution is 0.1. Interval is 100 ms.", 0);
            AddSIDIHelper(_collection, "vVRF", "In.v_Vehicle3", "Right front wheel speed UNIT : km/h MAX : 300 MIN : 0 (detection of min. 1.0 km/h) TRANS : V = P * 10. Resolution is 0.1. Interval is 100 ms.", 0);
            AddSIDIHelper(_collection, "Xacc", "Out.X_AccPedal", "Pedal position UNIT : % MAX : 100 MIN : 0 TRANS : V = P*1. Resolution is 0.1. Interval is 20ms.", 0);
            AddSIDIHelper(_collection, "Igna", "Out.fi_Ignition", "Actual ignition angle. A positive value is before TDC and a negative value is after TDC. Resolution is 0.1 °. Interval is Every combustion.", 0);
            AddSIDIHelper(_collection, "Teng", "In.T_Engine", "Engine coolant temperature UNIT : (C MAX : 150 MIN : -40 TRANS : V = P. Resolution is 1. Interval is 1000 ms.", 0);
            AddSIDIHelper(_collection, "Ioff", "IgnProt.fi_Offset", "Shows ignition angle output from offset functions. Resolution is 0.1 °.", 0);
            AddSIDIHelper(_collection, "Pbef", "In.p_AirBefThrottle", "Engine inlet air pressure UNIT : kPa MAX : 300 MIN : 0 TRANS : V = P * 10. Resolution is 0.1. Interval is Every combustion.", 0);
            AddSIDIHelper(_collection, "Pinl", "In.p_AirInlet", "Engine inlet air pressure UNIT : kPa MAX : 300 MIN : 0 TRANS : V = P * 10. Resolution is 0.1. Interval is Every combustion.", 0);
            AddSIDIHelper(_collection, "mReq", "m_Request", "Requested airmass", 0);
            AddSIDIHelper(_collection, "Miss", "Missf.nrOfCountedMisfire", "Counts the nr of misfire that has not been filtered or rpm diff filtered.", 0);
            AddSIDIHelper(_collection, "Pfac", "BoostProt.PFac", "Calculate P part for regulator. load diff * P const P = 100. Update : every 10 msec. Resolution is 0.1 %.", 0);
            AddSIDIHelper(_collection, "Ifac", "BoostProt.IFac", "Calculated I part for regulator. load diff * I const I = I + 1000. Update : every 10 msec. Resolution is 0.1 %.", 0);
            AddSIDIHelper(_collection, "PWM ", "Out.PWM_BoostCntrl", "Duty-cycle for boost pressure valve. Resolution is 0.1 %. Interval is every 20 ms.", 0);
            AddSIDIHelper(_collection, "tSta", "ECMStat.t_StartTime", "Engine start time, measured by measuring the time from that the battery volatage decreases 1.0V to the time engine speed reached 1000 rpm.", 0);
            AddSIDIHelper(_collection, "LIMP", "OBDAdap.ThrLimpHomeNr", "Last reported throttle limphome number.", 0);
            AddSIDIHelper(_collection, "Mode", "SID.ST_Mode", "Mode settings to see different values", 0);
            AddSIDIHelper(_collection, "Badp", "BoostAdap.Adaption", "Adaption value for boost control. Interval is Every 100ms.", 0);
            AddSIDIHelper(_collection, "Texh", "ExhaustProt.T_Exhaust", "Exhaust Gas temperature between exhaust manifold and turbine inlet (T7 pin 40)", 0);
            AddSIDIHelper(_collection, "Tmap", "ExhaustProt.T_TotMapVal", "Sum of load/rpm and ignition dependent steady state temperatures.", 0);
            AddSIDIHelper(_collection, "Tlim", "ExhaustProt.T_Limit", "Exhaust temperature limit for lambda 1.", 0);
            AddSIDIHelper(_collection, "Tclc", "ExhaustProt.T_CalcDly", "Delayed value of Exhaust.T_Calc", 0);
            AddSIDIHelper(_collection, "Eenb", "ExhaustCal.ST_Enable", "Is this flag is set and In.T_Engine is above its limit, the exhaust temperature algo becomes active.", 0);
            AddSIDIHelper(_collection, "ExST", "Exhaust.Status", "Status variable for exhaust temp calculation", 0);
            AddSIDIHelper(_collection, "LmST", "Lambda.Status", "Status byte for closed loop intergrator", 0);
            AddSIDIHelper(_collection, "Pgsi", "REPProt.ST_GSIState", "State of gear shift inhibitor", 0);
            AddSIDIHelper(_collection, "GSIs", "REPProt.p_AirAmbient", "Enable REP shift pattern on altitude below this pressure", 0);
            AddSIDIHelper(_collection, "Mclc", "TorqueProt.M_EngineByAcc", "Engine Torque measured by acceleration of vehicle", 0);
            AddSIDIHelper(_collection, "Tlmp","LimpIn.T_Engine","",0);
            AddSIDIHelper(_collection, "Akw1", "KnkAdaptAdap.RefValueWind", "", 0);
            AddSIDIHelper(_collection, "MiFi", "Missf.nrOfFilteredMisfire", "", 0);
            AddSIDIHelper(_collection, "Aft1", "AftStProt1.EnrFac", "", 0);
            AddSIDIHelper(_collection, "IpN1", "AirctlData.iPartN1", "", 0);
            AddSIDIHelper(_collection, "TFac", "TCompProt.EnrFac", "", 0);
            AddSIDIHelper(_collection, "Area", "In.A_Throttle", "", 0);
            /* AddSIDIHelper(_collection, "AdpN", "IdleAdap.Q_AirNeutral", "Adaption value for idlespeed regulation (drive not activated). Resolution 0.01g/s.", 0xF01046);
             AddSIDIHelper(_collection, "AdpD", "IdleAdap.Q_AirDrive", "Adaption value for idlespeed regulation (drive activated). Resolution 0.01g/s. ", 0xF01048);
             AddSIDIHelper(_collection, "Aadp", "AreaAdap.A_Throttle", "Adaption of throttle area. Interval is 250ms.", 0xF01040);
             AddSIDIHelper(_collection, "Amul", "AdpFuelProt.MulFuelAdapt", "Multiplicative fuel adaption value. Resolution is 0.01%.", 0xF03F5E);
             AddSIDIHelper(_collection, "Aadd", "AdpFuelProt.AddFuelAdapt", "Additive fuel adaption value. Resolution is 0.01%.", 0xF03F60);
             AddSIDIHelper(_collection, "Apur", "Purge.HCCont", "The content of HC in the purge air. Resolution is 0.1%.", 0xF04282);
             AddSIDIHelper(_collection, "Akw1", "KnkAdaptAdap.RefValueWind", "", 0xF01A3E);
             AddSIDIHelper(_collection, "Akw2", "", "", 0xF01A40);
             AddSIDIHelper(_collection, "TngA", "ActualIn.T_Engine", "Engine coolant temperature Unit deg C MAX: 150 MIN: -40 TRANS: V=P. Resolution is 1. Interval 1000ms.", 0xF04962);
             AddSIDIHelper(_collection, "nErr", "obdNoOfFaults", "Number of error codes stored.", 0xF069B0);
             AddSIDIHelper(_collection, "Fcod", "obdFaults", "Codes for errors stored.", 0xF038F2);
             AddSIDIHelper(_collection, "MiFi", "Missf.nrOfFilteredMisfire", "Number of missfires occurred.", 0xF03C76);
             AddSIDIHelper(_collection, "Tair", "In.T_AirInlet", "Inlet air temperature Unit deg C MAX: 140 MIN: -40 TRANS: V=P. Resolution is 1. Interval 1000ms.", 0xF048DE);
             AddSIDIHelper(_collection, "TTCM", "In.T_TCMOil", "Oil temperature in automatic gearbox.", 0xF0493A);
             AddSIDIHelper(_collection, "Gear", "In.X_ActualGear", "Actual gear on automatic gearboxes. 2 ° Reverse, 3 ° Neutral, 5 - Gear , 6 ° Gear 2, 7 ° Gear 3, 8 ° Gear 4, 11 ° Gear 3 lock up, 12 ° Gear 4 lock up, lock up interval is every 50ms.", 0xF048C8);
             AddSIDIHelper(_collection, "Fuel", "BfuelProt.CurrentFuelCon", "Current fuel consumption?", 0xF0412A);
             AddSIDIHelper(_collection, "ShPn", "In.ST_TCMShiftPattern", "Active TCM shift pattern, 0=eco, 1=pwr, 2=Wusp, 3=Wnt, 4=US1, 5=US2, 6=Hot1, 7=Hot2, 8=Jerk, 9=Rep, 10=DS, 11=Tap U/D", 0xF04944);
             AddSIDIHelper(_collection, "Xacc", "Out.X_Accpedal", "Pedal position Unit: %, Max 100, Min 0, Trans: V=P*1. Resolution is 0.1%. Interval is 20ms.", 0xF04B02);
             AddSIDIHelper(_collection, "Iput", "ActualIn.n_GearBoxIn", "Transmission input rpm (turbine speed). Used to detect when the load is changed for the engine when gear is engaged. Resolution is 1 rpm. Interval is every 50ms.", 0xF0494C);
             AddSIDIHelper(_collection, "DTI", "Out.M_DTI", "Drivers Torque Intention. The torque that the driver requests converted from air to torque. Limitations from all functions excluding TCM and TCS are included in the signal. Unit Nm Max 400 Min -100.", 0xF04B0C);
             AddSIDIHelper(_collection, "Pair", "In.p_AirInlet", "Engine inlet air pressure. Unit kPa Max 300 Min 0 Trans V=P*10. Resolution is 0.1. Interval is every combustion.", 0xF048E2);
             AddSIDIHelper(_collection, "Rpm", "In.n_Engine", "Engine speed. Unit rpm. Max 8000. Min 25. (Set to 10 when engine starts to move). Trans V=P. Interval is every combustion /5 ms when engine is still.", 0xF048CC);
             AddSIDIHelper(_collection, "Meng", "Out.M_Engine", "Engine torque. Unit Nm. Max 400. Min -100. Trans V=P. Resolution is 1. Interval is 10 ms.", 0xF04B08);
             AddSIDIHelper(_collection, "Peng", "ECMStat.P_Engine", "Calculated engine power. Measured in horsepower.", 0xF04B94);
             AddSIDIHelper(_collection, "GSI", "Out.CMD_GearShiftInhibit", "Prevent TCM from shifting", 0xF04B2E);
             AddSIDIHelper(_collection, "Jerk", "ECMStat.JerkFactor", "This factor describes the jerking of the engine. The formula for calulating this is abs(ECMStat.EngineDelta2)*factor. The factor is for scaling so it will be possible to filter it. The calibratable value used for filtering is nEngCal.FilterFactor. Since the jerk factor is based on every combustion, it is not possible to compare the numbers for 6 cylinder engines and 4 cylinder.", 0xF04B9C);
             AddSIDIHelper(_collection, "CLUi", "Out.CMD_CoastLUInhibit", "Inhibit coast slip lock up.", 0xF04B31);
             AddSIDIHelper(_collection, "JeLi", "JerkProt.JerkFactor", "Treshold value for changing shift pattern to 'no lockup'.", 0xF04B9E);
             AddSIDIHelper(_collection, "mAIR", "MAF.m_AirInlet", "Airmass in milligramper combustion. This airmass is the actual load value in the ECM (unfiltered). Calculated from ActualIn.Q_AirInlet. Resolution is 1 mg/c. Interval is every combustion.", 0xF034F6);
             AddSIDIHelper(_collection, "CSLU", "In.ST_TCMCSLU", "Coast Lock up slip state. 0=No request, 1=Fuel cut inhibit, 2=Fuel cut allowed.", 0xF04943);
             AddSIDIHelper(_collection, "MTCM", "ActualIn.M_TCMLimitReq", "Maximum engine torque request from TCM. Unit Nm, Max 400, Min -100, Trans V=P. Resolution is 1. Interval is 10 ms.", 0xF049AA);
             AddSIDIHelper(_collection, "Mlow", "TorqueProt.M_LowLim", "By the Torque Master selected lowest torque limit request, corrected with adaption value made at idle.", 0xF0358A);
             AddSIDIHelper(_collection, "Oput", "DiffPSProt.v_GearBoxOut", "TCM gearbox output speed converted to vehicle speed. Resolution is 0.1km/h. Interval is every 100 ms.", 0xF0340E);
             AddSIDIHelper(_collection, "Kph1", "ActualIn.v_Vehicle", "Left front wheel speed. Unit km/h, Max 300, Min 0 (detection of min 1.0km/h), Trans V=P*10. Resolution is 0.1. Interval is 100 ms", 0xF04986);
             AddSIDIHelper(_collection, "In.X", "In.X_AccPedal", "Pedal position Unit: %, Max 130, Min 0, Trans: V=P*10. Resolution is 0.1%. Interval is 20ms.", 0xF048F4);
             AddSIDIHelper(_collection, "Cmem", "EngTip.ST_Active", "Status flag showing if tipin is active. 0=Not active, 1=Tip-in active, 2=Tip-out active.", 0xF0342E);
             AddSIDIHelper(_collection, "Kph2", "ActualIn.v_Vehicle2", "Vehicle speed, measured on the rear wheel. Unit km/h, Max 300, Min 0, Trans V=P*10. Resolution is 0.1. Interval is 100 ms", 0xF049A8);
             AddSIDIHelper(_collection, "NoIg", "Out.ST_NoIgnitionRetard", "Ignition retarding is not allowed due to overheating the catalytic converter.", 0xF04B2F);
             AddSIDIHelper(_collection, "Tign", "", "Ignition timing?", 0x005904);
             AddSIDIHelper(_collection, "Mair", "In.M_TCSTorqueReq", "Maximum torque request from TCS system via CAN. Resolution is 1 Nm. Interval is every 20 ms.", 0xF04934);
             AddSIDIHelper(_collection, "Mtot", "In.M_TCSTotalReq", "Total torque request from ESP equipped cars. The difference in torque between In.M_TCSTorqueReq and In.M_TCSTotalReq is taken with ignition retardation. Resolution is 1 Nm. Interval is every 20 ms.", 0xF04938);
             AddSIDIHelper(_collection, "Mnom", "Torque.M_Nominal", "Nominal output torque at a certain engine speed and inlet airmass. Read from matrix.", 0xF0357A);
             AddSIDIHelper(_collection, "ay", "CanIn.p_Brake", "Brake pressure, ony implemented on cars with ESP. Resolution is 2 bar.", 0xF064D7);
             AddSIDIHelper(_collection, "LwsI", "CanIn.a_Lateral", "Lateral acceleration, only implemented on cars with ESP. Resolution is 0.5 m/s2.", 0xF064D8);
             AddSIDIHelper(_collection, "vGiF", "CanIn.fi_SteeringAngle", "Stearing angle (LwsIn), only implemented on cars with ESP. Resolution is 3 degrees.", 0xF064D9);
             AddSIDIHelper(_collection, "BMR", "CanIn.ST_EngineInterv", "Engine internvention is requested from ESP (AMR).", 0xF064DB);
             AddSIDIHelper(_collection, "AMR", "CanIn.fi_YawVelocity", "Yaw velocity (vGIF), only implemented on cars with ESP.Resolution is 0.02 degrees.", 0xF064DA);
             AddSIDIHelper(_collection, "vVLF", "In.v_Vehicle", "Left front wheel speed. Unit km/h, Max 300, Min 0 (detection of min 1.0km/h), Trans V=P*10. Resolution is 0.1. Interval is 100 ms", 0xF04900);
             AddSIDIHelper(_collection, "vVRF", "In.v_Vehicle3", "Right front wheel speed UNIT : km/h MAX : 300 MIN : 0 (detection of min. 1.0 km/h) TRANS : V = P * 10. Resolution is 0.1. Interval is 100 ms.", 0xF04902);
             AddSIDIHelper(_collection, "PrSt", "Purge.Status", "Status of the purge function.", 0xF04278);
             AddSIDIHelper(_collection, "Ppwm", "Purge.Valve", "Purge valve PWM. Resolution is 0.1 %.", 0xF0427A);
             AddSIDIHelper(_collection, "Pdif", "ECMStat.p_Diff", "Differance between inlet manifold air pressure and external air pressure. Resolution is 0.1 kPa.", 0xF04B84);
             AddSIDIHelper(_collection, "Flow", "Purge.Flow", "The actual purge flow. Resolution is 1 mg/s.", 0xF0427E);
             AddSIDIHelper(_collection, "ReqF", "PurgeProt.ReqFlow", "Requested purge flow. Resolution is 1 mg/s.", 0xF04298);
             AddSIDIHelper(_collection, "Perc", "PurgeProt.PurgePercent", "Purge flow/Air mass flow ratio. Resolution is 0.01 %.", 0xF042B2);
             AddSIDIHelper(_collection, "FFAd", "Purge.m_FuelPrg", "Fuel flow from purge. Resolution is 0.01 mg/c.", 0xF0428C);
             AddSIDIHelper(_collection, "HCnt", "Purge.HCCont", "The content of HC in the purge air. Resolution is 0.1 %.", 0xF04282);
             AddSIDIHelper(_collection, "Frez", "PurgeProt.AdpFreeze", "Adaption freeze status.", 0xF042AE);
             AddSIDIHelper(_collection, "PMXF", "PurgeProt.PdiffMaxFlow", "Maximum flow allowed by the diff. pressure. Resolution is 1 mg/s.", 0xF04294);
             AddSIDIHelper(_collection, "FMXF", "PurgeProt.FuelFacMaxFlow", "Maximum allowed purge flow in respect to maximum allowed fuel factor at actual load. Resolution is 1 mg/s.", 0xF04290);
             AddSIDIHelper(_collection, "Me85", "In.X_EthanolSensor", "", 0xF0493C);
             AddSIDIHelper(_collection, "Ad85", "E85.X_EthanolActual", "", 0xF03FD4);
             AddSIDIHelper(_collection, "Lamb", "Lambda.LambdaInt", "Global closed loop integrator. Update : every combustion. V6: Bank 1. Resolution is 0.01 %.", 0xF04242);
             AddSIDIHelper(_collection, "Ca85", "E85Prot.X_EthanolActual", "", 0xF03F98);
             AddSIDIHelper(_collection, "FFac", "Purge.FuelFac", "The fuelfactor from the purge function. Resolution is 0.01 %.", 0xF0427C);
             AddSIDIHelper(_collection, "ReFu", "E85Adap.ST_ReFuel", "", 0xF013FE);
             AddSIDIHelper(_collection, "STAd", "E85Adap.ST_Adap", "", 0xF013FA);
             AddSIDIHelper(_collection, "Crnk", "CrnkCas.ST_Fuel", "", 0xF03FF8);
             AddSIDIHelper(_collection, "MxLo", "LambdaProt.MaxLoadNorm", "Max load (airmass) for closed loop during normal conditions. Update : every combustion. Resolution is 1 mg/c.", 0xF041D2);
             AddSIDIHelper(_collection, "SFuL", "E85Adap.V_SavedFuelLevel", "", 0xF013F0);
             AddSIDIHelper(_collection, "VFue", "In.V_FuelTank", "Fuel level UNIT : l (litre) MAX : 100 MIN : 0 TRANS : V = P * 10. Resolution is 0.1. Interval is 1000 ms.", 0xF0491A);
             */
            return _collection;
        }

        private void AddSIDIHelper(SIDICollection m_collection, string shortdescr, string symbol, string info, int address)
        {
            SIDIHelper h = new SIDIHelper();
            //h.Value = value;
            h.Symbol = shortdescr;
            h.T7Symbol = symbol;
            h.Info = info;
            h.AddressSRAM = address;
            m_collection.Add(h);
        }
    }
}
