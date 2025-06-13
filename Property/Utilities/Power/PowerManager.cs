using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Property.Utilities.Power
{
	// Token: 0x0200053B RID: 1339
	public class PowerManager : Singleton<PowerManager>
	{
		// Token: 0x06007640 RID: 30272 RVA: 0x002058F8 File Offset: 0x00203AF8
		// Note: this type is marked as 'beforefieldinit'.
		static PowerManager()
		{
			Il2CppClassPointerStore<PowerManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property.Utilities.Power", "PowerManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PowerManager>.NativeClassPtr);
			PowerManager.NativeFieldInfoPtr_powerLineSegmentPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerManager>.NativeClassPtr, "powerLineSegmentPrefab");
			PowerManager.NativeFieldInfoPtr_pricePerkWh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerManager>.NativeClassPtr, "pricePerkWh");
			PowerManager.NativeFieldInfoPtr_usageAtTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerManager>.NativeClassPtr, "usageAtTime");
			PowerManager.NativeFieldInfoPtr_usageThisMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerManager>.NativeClassPtr, "usageThisMinute");
			PowerManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerManager>.NativeClassPtr, 100678260);
			PowerManager.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerManager>.NativeClassPtr, 100678261);
			PowerManager.NativeMethodInfoPtr_DayPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerManager>.NativeClassPtr, 100678262);
			PowerManager.NativeMethodInfoPtr_GetTotalUsage_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerManager>.NativeClassPtr, 100678263);
			PowerManager.NativeMethodInfoPtr_ConsumePower_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerManager>.NativeClassPtr, 100678264);
			PowerManager.NativeMethodInfoPtr_CreatePowerLine_Public_PowerLine_PowerNode_PowerNode_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerManager>.NativeClassPtr, 100678265);
			PowerManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerManager>.NativeClassPtr, 100678266);
		}

		// Token: 0x06007641 RID: 30273 RVA: 0x00205A04 File Offset: 0x00203C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231079, XrefRangeEnd = 231117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PowerManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007642 RID: 30274 RVA: 0x00205A40 File Offset: 0x00203C40
		[CallerCount(0)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerManager.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007643 RID: 30275 RVA: 0x00205A74 File Offset: 0x00203C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231117, XrefRangeEnd = 231121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DayPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerManager.NativeMethodInfoPtr_DayPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007644 RID: 30276 RVA: 0x00205AA8 File Offset: 0x00203CA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 231141, RefRangeEnd = 231143, XrefRangeStart = 231121, XrefRangeEnd = 231141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetTotalUsage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PowerManager.NativeMethodInfoPtr_GetTotalUsage_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007645 RID: 30277 RVA: 0x00205AE4 File Offset: 0x00203CE4
		[CallerCount(0)]
		public unsafe void ConsumePower(float kwh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref kwh;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerManager.NativeMethodInfoPtr_ConsumePower_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007646 RID: 30278 RVA: 0x00205B24 File Offset: 0x00203D24
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 231163, RefRangeEnd = 231166, XrefRangeStart = 231143, XrefRangeEnd = 231163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PowerLine CreatePowerLine(PowerNode nodeA, PowerNode nodeB, Property p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(nodeA);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nodeB);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerManager.NativeMethodInfoPtr_CreatePowerLine_Public_PowerLine_PowerNode_PowerNode_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PowerLine>(intPtr2) : null;
		}

		// Token: 0x06007647 RID: 30279 RVA: 0x00205B98 File Offset: 0x00203D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231166, XrefRangeEnd = 231176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PowerManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PowerManager>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007648 RID: 30280 RVA: 0x00037EBE File Offset: 0x000360BE
		public PowerManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023A4 RID: 9124
		// (get) Token: 0x06007649 RID: 30281 RVA: 0x00205BD4 File Offset: 0x00203DD4
		// (set) Token: 0x0600764A RID: 30282 RVA: 0x00037EC7 File Offset: 0x000360C7
		public unsafe GameObject powerLineSegmentPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerManager.NativeFieldInfoPtr_powerLineSegmentPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerManager.NativeFieldInfoPtr_powerLineSegmentPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023A5 RID: 9125
		// (get) Token: 0x0600764B RID: 30283 RVA: 0x00205C04 File Offset: 0x00203E04
		// (set) Token: 0x0600764C RID: 30284 RVA: 0x00037EE6 File Offset: 0x000360E6
		public unsafe static float pricePerkWh
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PowerManager.NativeFieldInfoPtr_pricePerkWh, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PowerManager.NativeFieldInfoPtr_pricePerkWh, (void*)(&value));
			}
		}

		// Token: 0x170023A6 RID: 9126
		// (get) Token: 0x0600764D RID: 30285 RVA: 0x00205C20 File Offset: 0x00203E20
		// (set) Token: 0x0600764E RID: 30286 RVA: 0x00037EF4 File Offset: 0x000360F4
		public unsafe Dictionary<int, float> usageAtTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerManager.NativeFieldInfoPtr_usageAtTime);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerManager.NativeFieldInfoPtr_usageAtTime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023A7 RID: 9127
		// (get) Token: 0x0600764F RID: 30287 RVA: 0x00205C50 File Offset: 0x00203E50
		// (set) Token: 0x06007650 RID: 30288 RVA: 0x00037F13 File Offset: 0x00036113
		public unsafe float usageThisMinute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerManager.NativeFieldInfoPtr_usageThisMinute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerManager.NativeFieldInfoPtr_usageThisMinute)) = value;
			}
		}

		// Token: 0x040050C3 RID: 20675
		private static readonly IntPtr NativeFieldInfoPtr_powerLineSegmentPrefab;

		// Token: 0x040050C4 RID: 20676
		private static readonly IntPtr NativeFieldInfoPtr_pricePerkWh;

		// Token: 0x040050C5 RID: 20677
		private static readonly IntPtr NativeFieldInfoPtr_usageAtTime;

		// Token: 0x040050C6 RID: 20678
		private static readonly IntPtr NativeFieldInfoPtr_usageThisMinute;

		// Token: 0x040050C7 RID: 20679
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040050C8 RID: 20680
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x040050C9 RID: 20681
		private static readonly IntPtr NativeMethodInfoPtr_DayPass_Private_Void_0;

		// Token: 0x040050CA RID: 20682
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalUsage_Public_Single_0;

		// Token: 0x040050CB RID: 20683
		private static readonly IntPtr NativeMethodInfoPtr_ConsumePower_Public_Void_Single_0;

		// Token: 0x040050CC RID: 20684
		private static readonly IntPtr NativeMethodInfoPtr_CreatePowerLine_Public_PowerLine_PowerNode_PowerNode_Property_0;

		// Token: 0x040050CD RID: 20685
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
