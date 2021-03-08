// Generated by Haxe 4.1.1

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace electricalc {
	public class ElectricalCalculator : global::haxe.lang.HxObject {
		
		static ElectricalCalculator() {
			unchecked{
				#line 8 "/my-component/src/electricalc/ElectriCalc.hx"
				global::haxe.lang.FieldLookup.addFields(new int[]{957002115}, new string[]{"registerMyMethods"});
			}
		}
		#line default
		
		public ElectricalCalculator(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public ElectricalCalculator(global::maglev.MagLev maglev) {
			#line 11 "/my-component/src/electricalc/ElectriCalc.hx"
			global::electricalc.ElectricalCalculator.__hx_ctor_electricalc_ElectricalCalculator(this, maglev);
		}
		#line default
		
		protected static void __hx_ctor_electricalc_ElectricalCalculator(global::electricalc.ElectricalCalculator __hx_this, global::maglev.MagLev maglev) {
			#line 12 "/my-component/src/electricalc/ElectriCalc.hx"
			__hx_this.maglev = maglev;
			__hx_this.registerMyMethods();
		}
		#line default
		
		public global::maglev.MagLev maglev;
		
		public virtual void registerMyMethods() {
			#line 17 "/my-component/src/electricalc/ElectriCalc.hx"
			global::maglev.MagLev bus = this.maglev;
			#line 19 "/my-component/src/electricalc/ElectriCalc.hx"
			this.maglev.register("ElectricalCalculator.ConvertPhaseAngleToPowerFactor", global::maglev.MagLevFunction.fromFunction(new global::electricalc.ElectricalCalculator_registerMyMethods_19__Fun(bus)));
			#line 30 "/my-component/src/electricalc/ElectriCalc.hx"
			this.maglev.register("ElectricalCalculator.ConvertPowerFactorToPhaseAngle", global::maglev.MagLevFunction.fromFunction(new global::electricalc.ElectricalCalculator_registerMyMethods_30__Fun(bus)));
			#line 41 "/my-component/src/electricalc/ElectriCalc.hx"
			this.maglev.register("ElectricalCalculator.CalculateSinglePhasePower", global::maglev.MagLevFunction.fromFunction(new global::electricalc.ElectricalCalculator_registerMyMethods_41__Fun(bus)));
			#line 52 "/my-component/src/electricalc/ElectriCalc.hx"
			this.maglev.register("ElectricalCalculator.CalculateThreePhasePower", global::maglev.MagLevFunction.fromFunction(new global::electricalc.ElectricalCalculator_registerMyMethods_52__Fun(bus)));
		}
		#line default
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 8 "/my-component/src/electricalc/ElectriCalc.hx"
				switch (hash) {
					case 858513194:
					{
						#line 8 "/my-component/src/electricalc/ElectriCalc.hx"
						this.maglev = ((global::maglev.MagLev) (@value) );
						#line 8 "/my-component/src/electricalc/ElectriCalc.hx"
						return @value;
					}
					
					
					default:
					{
						#line 8 "/my-component/src/electricalc/ElectriCalc.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 8 "/my-component/src/electricalc/ElectriCalc.hx"
				switch (hash) {
					case 957002115:
					{
						#line 8 "/my-component/src/electricalc/ElectriCalc.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "registerMyMethods", 957002115)) );
					}
					
					
					case 858513194:
					{
						#line 8 "/my-component/src/electricalc/ElectriCalc.hx"
						return this.maglev;
					}
					
					
					default:
					{
						#line 8 "/my-component/src/electricalc/ElectriCalc.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 8 "/my-component/src/electricalc/ElectriCalc.hx"
				switch (hash) {
					case 957002115:
					{
						#line 8 "/my-component/src/electricalc/ElectriCalc.hx"
						this.registerMyMethods();
						#line 8 "/my-component/src/electricalc/ElectriCalc.hx"
						break;
					}
					
					
					default:
					{
						#line 8 "/my-component/src/electricalc/ElectriCalc.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 8 "/my-component/src/electricalc/ElectriCalc.hx"
				return null;
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::Array<string> baseArr) {
			#line 8 "/my-component/src/electricalc/ElectriCalc.hx"
			baseArr.push("maglev");
			#line 8 "/my-component/src/electricalc/ElectriCalc.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace electricalc {
	public class ElectricalCalculator_registerMyMethods_19__Fun : global::haxe.lang.Function {
		
		public ElectricalCalculator_registerMyMethods_19__Fun(global::maglev.MagLev bus) : base(1, 0) {
			#line 19 "/my-component/src/electricalc/ElectriCalc.hx"
			this.bus = bus;
		}
		#line default
		
		public override object __hx_invoke1_o(double __fn_float1, object __fn_dyn1) {
			unchecked {
				#line 19 "/my-component/src/electricalc/ElectriCalc.hx"
				global::maglev.MagLevArray args = ( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? (((global::maglev.MagLevArray) (((object) (__fn_float1) )) )) : (((global::maglev.MagLevArray) (__fn_dyn1) )) );
				global::maglev.MagLevArray data = global::maglev.MagLevArray.create();
				#line 21 "/my-component/src/electricalc/ElectriCalc.hx"
				data.push(global::maglev.MagLevString.fromString("_not_implemented_"));
				data.push(global::maglev.MagLevString.fromString("ElectricalCalculator.ConvertPhaseAngleToPowerFactor"));
				#line 23 "/my-component/src/electricalc/ElectriCalc.hx"
				data.push(global::maglev.MagLevString.fromString("electricalc"));
				this.bus.call("MindPowered.Telemetry.Send", data);
				#line 25 "/my-component/src/electricalc/ElectriCalc.hx"
				global::maglev.MagLevError err = global::maglev.MagLevError.create(-20000, "You are trying to use the \'ElectricalCalculator.ConvertPhaseAngleToPowerFactor\' method but it\'s not quite done yet. Please email support@mindpowered.dev to find out when it will be done.", data);
				global::maglev.MagLevResult result = global::maglev.MagLevResult.fromError(err);
				#line 27 "/my-component/src/electricalc/ElectriCalc.hx"
				return result;
			}
			#line default
		}
		
		
		public global::maglev.MagLev bus;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace electricalc {
	public class ElectricalCalculator_registerMyMethods_30__Fun : global::haxe.lang.Function {
		
		public ElectricalCalculator_registerMyMethods_30__Fun(global::maglev.MagLev bus) : base(1, 0) {
			#line 30 "/my-component/src/electricalc/ElectriCalc.hx"
			this.bus = bus;
		}
		#line default
		
		public override object __hx_invoke1_o(double __fn_float1, object __fn_dyn1) {
			unchecked {
				#line 30 "/my-component/src/electricalc/ElectriCalc.hx"
				global::maglev.MagLevArray args = ( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? (((global::maglev.MagLevArray) (((object) (__fn_float1) )) )) : (((global::maglev.MagLevArray) (__fn_dyn1) )) );
				global::maglev.MagLevArray data = global::maglev.MagLevArray.create();
				#line 32 "/my-component/src/electricalc/ElectriCalc.hx"
				data.push(global::maglev.MagLevString.fromString("_not_implemented_"));
				data.push(global::maglev.MagLevString.fromString("ElectricalCalculator.ConvertPowerFactorToPhaseAngle"));
				#line 34 "/my-component/src/electricalc/ElectriCalc.hx"
				data.push(global::maglev.MagLevString.fromString("electricalc"));
				this.bus.call("MindPowered.Telemetry.Send", data);
				#line 36 "/my-component/src/electricalc/ElectriCalc.hx"
				global::maglev.MagLevError err = global::maglev.MagLevError.create(-20000, "You are trying to use the \'ElectricalCalculator.ConvertPowerFactorToPhaseAngle\' method but it\'s not quite done yet. Please email support@mindpowered.dev to find out when it will be done.", data);
				global::maglev.MagLevResult result = global::maglev.MagLevResult.fromError(err);
				#line 38 "/my-component/src/electricalc/ElectriCalc.hx"
				return result;
			}
			#line default
		}
		
		
		public global::maglev.MagLev bus;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace electricalc {
	public class ElectricalCalculator_registerMyMethods_41__Fun : global::haxe.lang.Function {
		
		public ElectricalCalculator_registerMyMethods_41__Fun(global::maglev.MagLev bus) : base(1, 0) {
			#line 41 "/my-component/src/electricalc/ElectriCalc.hx"
			this.bus = bus;
		}
		#line default
		
		public override object __hx_invoke1_o(double __fn_float1, object __fn_dyn1) {
			unchecked {
				#line 41 "/my-component/src/electricalc/ElectriCalc.hx"
				global::maglev.MagLevArray args = ( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? (((global::maglev.MagLevArray) (((object) (__fn_float1) )) )) : (((global::maglev.MagLevArray) (__fn_dyn1) )) );
				global::maglev.MagLevArray data = global::maglev.MagLevArray.create();
				#line 43 "/my-component/src/electricalc/ElectriCalc.hx"
				data.push(global::maglev.MagLevString.fromString("_not_implemented_"));
				data.push(global::maglev.MagLevString.fromString("ElectricalCalculator.CalculateSinglePhasePower"));
				#line 45 "/my-component/src/electricalc/ElectriCalc.hx"
				data.push(global::maglev.MagLevString.fromString("electricalc"));
				this.bus.call("MindPowered.Telemetry.Send", data);
				#line 47 "/my-component/src/electricalc/ElectriCalc.hx"
				global::maglev.MagLevError err = global::maglev.MagLevError.create(-20000, "You are trying to use the \'ElectricalCalculator.CalculateSinglePhasePower\' method but it\'s not quite done yet. Please email support@mindpowered.dev to find out when it will be done.", data);
				global::maglev.MagLevResult result = global::maglev.MagLevResult.fromError(err);
				#line 49 "/my-component/src/electricalc/ElectriCalc.hx"
				return result;
			}
			#line default
		}
		
		
		public global::maglev.MagLev bus;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace electricalc {
	public class ElectricalCalculator_registerMyMethods_52__Fun : global::haxe.lang.Function {
		
		public ElectricalCalculator_registerMyMethods_52__Fun(global::maglev.MagLev bus) : base(1, 0) {
			#line 52 "/my-component/src/electricalc/ElectriCalc.hx"
			this.bus = bus;
		}
		#line default
		
		public override object __hx_invoke1_o(double __fn_float1, object __fn_dyn1) {
			unchecked {
				#line 52 "/my-component/src/electricalc/ElectriCalc.hx"
				global::maglev.MagLevArray args = ( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? (((global::maglev.MagLevArray) (((object) (__fn_float1) )) )) : (((global::maglev.MagLevArray) (__fn_dyn1) )) );
				global::maglev.MagLevArray data = global::maglev.MagLevArray.create();
				#line 54 "/my-component/src/electricalc/ElectriCalc.hx"
				data.push(global::maglev.MagLevString.fromString("_not_implemented_"));
				data.push(global::maglev.MagLevString.fromString("ElectricalCalculator.CalculateThreePhasePower"));
				#line 56 "/my-component/src/electricalc/ElectriCalc.hx"
				data.push(global::maglev.MagLevString.fromString("electricalc"));
				this.bus.call("MindPowered.Telemetry.Send", data);
				#line 58 "/my-component/src/electricalc/ElectriCalc.hx"
				global::maglev.MagLevError err = global::maglev.MagLevError.create(-20000, "You are trying to use the \'ElectricalCalculator.CalculateThreePhasePower\' method but it\'s not quite done yet. Please email support@mindpowered.dev to find out when it will be done.", data);
				global::maglev.MagLevResult result = global::maglev.MagLevResult.fromError(err);
				#line 60 "/my-component/src/electricalc/ElectriCalc.hx"
				return result;
			}
			#line default
		}
		
		
		public global::maglev.MagLev bus;
		
	}
}


