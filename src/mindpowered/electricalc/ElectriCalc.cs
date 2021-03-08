/**
 * Copyright Mind Powered Corporation 2020
 * 
 * https://mindpowered.dev/
 */

using System.Collections.Generic;

/**
 * A library for calculations related to electrical wiring and circuits
 */
namespace mindpowered.electricalc {
	public delegate void MyCallbackDelegate(object o);

	public class ElectriCalc
	{
		public ElectriCalc()
		{
			global::maglev.MagLev bus = global::maglev.MagLev.getInstance("default");
			global::electricalc.ElectricalCalculator myinstance = new global::electricalc.ElectricalCalculator(bus);
		}

		/**
		 * Convert from Phase Angle to Power Factor
		 * @param phaseAngle Phase Angle in degrees
		 * @return {double} Power Factor
		*/
		public double ConvertPhaseAngleToPowerFactor(double phaseAngle)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(phaseAngle);
			double ret = 0;
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (double) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ElectriCalc.ConvertPhaseAngleToPowerFactor", args, async_callback);
			return ret;
		}

		/**
		 * Convert from Power Factor to Phase Angle
		 * @param powerFactor Power Factor
		 * @return {double} Phase Angle in degrees
		*/
		public double ConvertPowerFactorToPhaseAngle(double powerFactor)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(powerFactor);
			double ret = 0;
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (double) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ElectriCalc.ConvertPowerFactorToPhaseAngle", args, async_callback);
			return ret;
		}

		/**
		 * Calcualte single phase power based on measured voltage and current
		 * @param voltage Measured voltage in Volts
		 * @param current Measured current in Amps
		 * @return {double} Apparent Power in VA
		*/
		public double CalculateSinglePhasePower(double voltage, double current)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(voltage);
			args.push(current);
			double ret = 0;
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (double) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ElectriCalc.CalculateSinglePhasePower", args, async_callback);
			return ret;
		}

		/**
		 * Calcualte three phase power based on measured voltage and current
		 * @param voltage Measured voltage in Volts
		 * @param lineTo Which voltage was measured. Must be "line" or "netural"
		 * @param current Measured current in Amps
		 * @return {double} Apparent Power in VA
		*/
		public double CalculateThreePhasePower(double voltage, string lineTo, double current)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(voltage);
			args.push(lineTo);
			args.push(current);
			double ret = 0;
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (double) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ElectriCalc.CalculateThreePhasePower", args, async_callback);
			return ret;
		}

	}
}

