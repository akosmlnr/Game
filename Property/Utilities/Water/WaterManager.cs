using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Property.Utilities.Water
{
	// Token: 0x02000539 RID: 1337
	public class WaterManager : Singleton<WaterManager>
	{
		// Token: 0x06007604 RID: 30212 RVA: 0x00204CB4 File Offset: 0x00202EB4
		// Note: this type is marked as 'beforefieldinit'.
		static WaterManager()
		{
			Il2CppClassPointerStore<WaterManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property.Utilities.Water", "WaterManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaterManager>.NativeClassPtr);
			WaterManager.NativeFieldInfoPtr_waterPipePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterManager>.NativeClassPtr, "waterPipePrefab");
			WaterManager.NativeFieldInfoPtr_pricePerL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterManager>.NativeClassPtr, "pricePerL");
			WaterManager.NativeFieldInfoPtr_usageAtTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterManager>.NativeClassPtr, "usageAtTime");
			WaterManager.NativeFieldInfoPtr_usageThisMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterManager>.NativeClassPtr, "usageThisMinute");
			WaterManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterManager>.NativeClassPtr, 100678234);
			WaterManager.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterManager>.NativeClassPtr, 100678235);
			WaterManager.NativeMethodInfoPtr_DayPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterManager>.NativeClassPtr, 100678236);
			WaterManager.NativeMethodInfoPtr_GetTotalUsage_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterManager>.NativeClassPtr, 100678237);
			WaterManager.NativeMethodInfoPtr_ConsumeWater_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterManager>.NativeClassPtr, 100678238);
			WaterManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterManager>.NativeClassPtr, 100678239);
		}

		// Token: 0x06007605 RID: 30213 RVA: 0x00204DAC File Offset: 0x00202FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230608, XrefRangeEnd = 230646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007606 RID: 30214 RVA: 0x00204DE8 File Offset: 0x00202FE8
		[CallerCount(0)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterManager.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007607 RID: 30215 RVA: 0x00204E1C File Offset: 0x0020301C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230646, XrefRangeEnd = 230650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DayPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterManager.NativeMethodInfoPtr_DayPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007608 RID: 30216 RVA: 0x00204E50 File Offset: 0x00203050
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 230670, RefRangeEnd = 230672, XrefRangeStart = 230650, XrefRangeEnd = 230670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetTotalUsage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WaterManager.NativeMethodInfoPtr_GetTotalUsage_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007609 RID: 30217 RVA: 0x00204E8C File Offset: 0x0020308C
		[CallerCount(0)]
		public unsafe void ConsumeWater(float litres)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref litres;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterManager.NativeMethodInfoPtr_ConsumeWater_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600760A RID: 30218 RVA: 0x00204ECC File Offset: 0x002030CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230672, XrefRangeEnd = 230682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaterManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaterManager>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600760B RID: 30219 RVA: 0x00037D29 File Offset: 0x00035F29
		public WaterManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002394 RID: 9108
		// (get) Token: 0x0600760C RID: 30220 RVA: 0x00204F08 File Offset: 0x00203108
		// (set) Token: 0x0600760D RID: 30221 RVA: 0x00037D32 File Offset: 0x00035F32
		public unsafe GameObject waterPipePrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterManager.NativeFieldInfoPtr_waterPipePrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterManager.NativeFieldInfoPtr_waterPipePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002395 RID: 9109
		// (get) Token: 0x0600760E RID: 30222 RVA: 0x00204F38 File Offset: 0x00203138
		// (set) Token: 0x0600760F RID: 30223 RVA: 0x00037D51 File Offset: 0x00035F51
		public unsafe static float pricePerL
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(WaterManager.NativeFieldInfoPtr_pricePerL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WaterManager.NativeFieldInfoPtr_pricePerL, (void*)(&value));
			}
		}

		// Token: 0x17002396 RID: 9110
		// (get) Token: 0x06007610 RID: 30224 RVA: 0x00204F54 File Offset: 0x00203154
		// (set) Token: 0x06007611 RID: 30225 RVA: 0x00037D5F File Offset: 0x00035F5F
		public unsafe Dictionary<int, float> usageAtTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterManager.NativeFieldInfoPtr_usageAtTime);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterManager.NativeFieldInfoPtr_usageAtTime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002397 RID: 9111
		// (get) Token: 0x06007612 RID: 30226 RVA: 0x00204F84 File Offset: 0x00203184
		// (set) Token: 0x06007613 RID: 30227 RVA: 0x00037D7E File Offset: 0x00035F7E
		public unsafe float usageThisMinute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterManager.NativeFieldInfoPtr_usageThisMinute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterManager.NativeFieldInfoPtr_usageThisMinute)) = value;
			}
		}

		// Token: 0x0400509B RID: 20635
		private static readonly IntPtr NativeFieldInfoPtr_waterPipePrefab;

		// Token: 0x0400509C RID: 20636
		private static readonly IntPtr NativeFieldInfoPtr_pricePerL;

		// Token: 0x0400509D RID: 20637
		private static readonly IntPtr NativeFieldInfoPtr_usageAtTime;

		// Token: 0x0400509E RID: 20638
		private static readonly IntPtr NativeFieldInfoPtr_usageThisMinute;

		// Token: 0x0400509F RID: 20639
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040050A0 RID: 20640
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x040050A1 RID: 20641
		private static readonly IntPtr NativeMethodInfoPtr_DayPass_Private_Void_0;

		// Token: 0x040050A2 RID: 20642
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalUsage_Public_Single_0;

		// Token: 0x040050A3 RID: 20643
		private static readonly IntPtr NativeMethodInfoPtr_ConsumeWater_Public_Void_Single_0;

		// Token: 0x040050A4 RID: 20644
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
