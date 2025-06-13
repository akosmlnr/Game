using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x02000527 RID: 1319
	public class Sensor : MonoBehaviour
	{
		// Token: 0x06007312 RID: 29458 RVA: 0x001FB16C File Offset: 0x001F936C
		// Note: this type is marked as 'beforefieldinit'.
		static Sensor()
		{
			Il2CppClassPointerStore<Sensor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "Sensor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sensor>.NativeClassPtr);
			Sensor.NativeFieldInfoPtr_obstruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sensor>.NativeClassPtr, "obstruction");
			Sensor.NativeFieldInfoPtr_obstructionDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sensor>.NativeClassPtr, "obstructionDistance");
			Sensor.NativeFieldInfoPtr_checkRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sensor>.NativeClassPtr, "checkRate");
			Sensor.NativeFieldInfoPtr_minDetectionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sensor>.NativeClassPtr, "minDetectionRange");
			Sensor.NativeFieldInfoPtr_maxDetectionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sensor>.NativeClassPtr, "maxDetectionRange");
			Sensor.NativeFieldInfoPtr_checkRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sensor>.NativeClassPtr, "checkRadius");
			Sensor.NativeFieldInfoPtr_checkMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sensor>.NativeClassPtr, "checkMask");
			Sensor.NativeFieldInfoPtr_vehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sensor>.NativeClassPtr, "vehicle");
			Sensor.NativeFieldInfoPtr_calculatedDetectionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sensor>.NativeClassPtr, "calculatedDetectionRange");
			Sensor.NativeFieldInfoPtr_hit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sensor>.NativeClassPtr, "hit");
			Sensor.NativeFieldInfoPtr_hits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sensor>.NativeClassPtr, "hits");
			Sensor.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sensor>.NativeClassPtr, 100677867);
			Sensor.NativeMethodInfoPtr_Check_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sensor>.NativeClassPtr, 100677868);
			Sensor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sensor>.NativeClassPtr, 100677869);
			Sensor.NativeMethodInfoPtr__Check_b__12_0_Private_Single_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sensor>.NativeClassPtr, 100677870);
		}

		// Token: 0x06007313 RID: 29459 RVA: 0x001FB2C8 File Offset: 0x001F94C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226311, XrefRangeEnd = 226318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sensor.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007314 RID: 29460 RVA: 0x001FB304 File Offset: 0x001F9504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226318, XrefRangeEnd = 226420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Check()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sensor.NativeMethodInfoPtr_Check_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007315 RID: 29461 RVA: 0x001FB338 File Offset: 0x001F9538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226420, XrefRangeEnd = 226428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sensor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sensor>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sensor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007316 RID: 29462 RVA: 0x001FB374 File Offset: 0x001F9574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226428, XrefRangeEnd = 226434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float _Check_b__12_0(RaycastHit x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Sensor.NativeMethodInfoPtr__Check_b__12_0_Private_Single_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007317 RID: 29463 RVA: 0x00036673 File Offset: 0x00034873
		public Sensor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002292 RID: 8850
		// (get) Token: 0x06007318 RID: 29464 RVA: 0x001FB3C0 File Offset: 0x001F95C0
		// (set) Token: 0x06007319 RID: 29465 RVA: 0x0003667C File Offset: 0x0003487C
		public unsafe Collider obstruction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_obstruction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_obstruction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002293 RID: 8851
		// (get) Token: 0x0600731A RID: 29466 RVA: 0x001FB3F0 File Offset: 0x001F95F0
		// (set) Token: 0x0600731B RID: 29467 RVA: 0x0003669B File Offset: 0x0003489B
		public unsafe float obstructionDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_obstructionDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_obstructionDistance)) = value;
			}
		}

		// Token: 0x17002294 RID: 8852
		// (get) Token: 0x0600731C RID: 29468 RVA: 0x001FB418 File Offset: 0x001F9618
		// (set) Token: 0x0600731D RID: 29469 RVA: 0x000366B6 File Offset: 0x000348B6
		public unsafe static float checkRate
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Sensor.NativeFieldInfoPtr_checkRate, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Sensor.NativeFieldInfoPtr_checkRate, (void*)(&value));
			}
		}

		// Token: 0x17002295 RID: 8853
		// (get) Token: 0x0600731E RID: 29470 RVA: 0x001FB434 File Offset: 0x001F9634
		// (set) Token: 0x0600731F RID: 29471 RVA: 0x000366C4 File Offset: 0x000348C4
		public unsafe float minDetectionRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_minDetectionRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_minDetectionRange)) = value;
			}
		}

		// Token: 0x17002296 RID: 8854
		// (get) Token: 0x06007320 RID: 29472 RVA: 0x001FB45C File Offset: 0x001F965C
		// (set) Token: 0x06007321 RID: 29473 RVA: 0x000366DF File Offset: 0x000348DF
		public unsafe float maxDetectionRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_maxDetectionRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_maxDetectionRange)) = value;
			}
		}

		// Token: 0x17002297 RID: 8855
		// (get) Token: 0x06007322 RID: 29474 RVA: 0x001FB484 File Offset: 0x001F9684
		// (set) Token: 0x06007323 RID: 29475 RVA: 0x000366FA File Offset: 0x000348FA
		public unsafe float checkRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_checkRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_checkRadius)) = value;
			}
		}

		// Token: 0x17002298 RID: 8856
		// (get) Token: 0x06007324 RID: 29476 RVA: 0x001FB4AC File Offset: 0x001F96AC
		// (set) Token: 0x06007325 RID: 29477 RVA: 0x00036715 File Offset: 0x00034915
		public unsafe LayerMask checkMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_checkMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_checkMask)) = value;
			}
		}

		// Token: 0x17002299 RID: 8857
		// (get) Token: 0x06007326 RID: 29478 RVA: 0x001FB4D4 File Offset: 0x001F96D4
		// (set) Token: 0x06007327 RID: 29479 RVA: 0x00036730 File Offset: 0x00034930
		public unsafe LandVehicle vehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_vehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_vehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700229A RID: 8858
		// (get) Token: 0x06007328 RID: 29480 RVA: 0x001FB504 File Offset: 0x001F9704
		// (set) Token: 0x06007329 RID: 29481 RVA: 0x0003674F File Offset: 0x0003494F
		public unsafe float calculatedDetectionRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_calculatedDetectionRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_calculatedDetectionRange)) = value;
			}
		}

		// Token: 0x1700229B RID: 8859
		// (get) Token: 0x0600732A RID: 29482 RVA: 0x001FB52C File Offset: 0x001F972C
		// (set) Token: 0x0600732B RID: 29483 RVA: 0x0003676A File Offset: 0x0003496A
		public unsafe RaycastHit hit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_hit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_hit)) = value;
			}
		}

		// Token: 0x1700229C RID: 8860
		// (get) Token: 0x0600732C RID: 29484 RVA: 0x001FB554 File Offset: 0x001F9754
		// (set) Token: 0x0600732D RID: 29485 RVA: 0x00036785 File Offset: 0x00034985
		public unsafe List<RaycastHit> hits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_hits);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RaycastHit>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_hits), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004E99 RID: 20121
		private static readonly IntPtr NativeFieldInfoPtr_obstruction;

		// Token: 0x04004E9A RID: 20122
		private static readonly IntPtr NativeFieldInfoPtr_obstructionDistance;

		// Token: 0x04004E9B RID: 20123
		private static readonly IntPtr NativeFieldInfoPtr_checkRate;

		// Token: 0x04004E9C RID: 20124
		private static readonly IntPtr NativeFieldInfoPtr_minDetectionRange;

		// Token: 0x04004E9D RID: 20125
		private static readonly IntPtr NativeFieldInfoPtr_maxDetectionRange;

		// Token: 0x04004E9E RID: 20126
		private static readonly IntPtr NativeFieldInfoPtr_checkRadius;

		// Token: 0x04004E9F RID: 20127
		private static readonly IntPtr NativeFieldInfoPtr_checkMask;

		// Token: 0x04004EA0 RID: 20128
		private static readonly IntPtr NativeFieldInfoPtr_vehicle;

		// Token: 0x04004EA1 RID: 20129
		private static readonly IntPtr NativeFieldInfoPtr_calculatedDetectionRange;

		// Token: 0x04004EA2 RID: 20130
		private static readonly IntPtr NativeFieldInfoPtr_hit;

		// Token: 0x04004EA3 RID: 20131
		private static readonly IntPtr NativeFieldInfoPtr_hits;

		// Token: 0x04004EA4 RID: 20132
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04004EA5 RID: 20133
		private static readonly IntPtr NativeMethodInfoPtr_Check_Public_Void_0;

		// Token: 0x04004EA6 RID: 20134
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004EA7 RID: 20135
		private static readonly IntPtr NativeMethodInfoPtr__Check_b__12_0_Private_Single_RaycastHit_0;
	}
}
