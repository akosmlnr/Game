using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Property;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone
{
	// Token: 0x020006C5 RID: 1733
	public class UtilitiesApp : App<UtilitiesApp>
	{
		// Token: 0x060099DE RID: 39390 RVA: 0x00277688 File Offset: 0x00275888
		// Note: this type is marked as 'beforefieldinit'.
		static UtilitiesApp()
		{
			Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone", "UtilitiesApp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr);
			UtilitiesApp.NativeFieldInfoPtr_water_Usage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, "water_Usage");
			UtilitiesApp.NativeFieldInfoPtr_water_Cost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, "water_Cost");
			UtilitiesApp.NativeFieldInfoPtr_water_Total = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, "water_Total");
			UtilitiesApp.NativeFieldInfoPtr_electricity_Usage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, "electricity_Usage");
			UtilitiesApp.NativeFieldInfoPtr_electricity_Cost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, "electricity_Cost");
			UtilitiesApp.NativeFieldInfoPtr_electricity_Total = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, "electricity_Total");
			UtilitiesApp.NativeFieldInfoPtr_dumpster_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, "dumpster_Count");
			UtilitiesApp.NativeFieldInfoPtr_dumpster_EmptyCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, "dumpster_EmptyCost");
			UtilitiesApp.NativeFieldInfoPtr_dumpster_Total = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, "dumpster_Total");
			UtilitiesApp.NativeFieldInfoPtr_dumpsterButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, "dumpsterButton");
			UtilitiesApp.NativeFieldInfoPtr_propertySelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, "propertySelector");
			UtilitiesApp.NativeFieldInfoPtr_selectedProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, "selectedProperty");
			UtilitiesApp.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, 100682383);
			UtilitiesApp.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, 100682384);
			UtilitiesApp.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, 100682385);
			UtilitiesApp.NativeMethodInfoPtr_RefreshShownValues_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, 100682386);
			UtilitiesApp.NativeMethodInfoPtr_OnDayPass_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, 100682387);
			UtilitiesApp.NativeMethodInfoPtr_Round_Private_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, 100682388);
			UtilitiesApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, 100682389);
			UtilitiesApp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, 100682390);
		}

		// Token: 0x060099DF RID: 39391 RVA: 0x00277848 File Offset: 0x00275A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275307, XrefRangeEnd = 275365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UtilitiesApp.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060099E0 RID: 39392 RVA: 0x00277884 File Offset: 0x00275A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275365, XrefRangeEnd = 275397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UtilitiesApp.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060099E1 RID: 39393 RVA: 0x002778C0 File Offset: 0x00275AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275397, XrefRangeEnd = 275402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UtilitiesApp.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060099E2 RID: 39394 RVA: 0x002778FC File Offset: 0x00275AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275402, XrefRangeEnd = 275461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshShownValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UtilitiesApp.NativeMethodInfoPtr_RefreshShownValues_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060099E3 RID: 39395 RVA: 0x00277938 File Offset: 0x00275B38
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDayPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UtilitiesApp.NativeMethodInfoPtr_OnDayPass_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060099E4 RID: 39396 RVA: 0x00277974 File Offset: 0x00275B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275461, XrefRangeEnd = 275464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float Round(float n, float decimals)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref n;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref decimals;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(UtilitiesApp.NativeMethodInfoPtr_Round_Private_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060099E5 RID: 39397 RVA: 0x002779CC File Offset: 0x00275BCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275464, XrefRangeEnd = 275467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UtilitiesApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060099E6 RID: 39398 RVA: 0x00277A18 File Offset: 0x00275C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275467, XrefRangeEnd = 275473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UtilitiesApp() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilitiesApp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060099E7 RID: 39399 RVA: 0x0004A958 File Offset: 0x00048B58
		public UtilitiesApp(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002F00 RID: 12032
		// (get) Token: 0x060099E8 RID: 39400 RVA: 0x00277A54 File Offset: 0x00275C54
		// (set) Token: 0x060099E9 RID: 39401 RVA: 0x0004A961 File Offset: 0x00048B61
		public unsafe Text water_Usage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_water_Usage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_water_Usage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F01 RID: 12033
		// (get) Token: 0x060099EA RID: 39402 RVA: 0x00277A84 File Offset: 0x00275C84
		// (set) Token: 0x060099EB RID: 39403 RVA: 0x0004A980 File Offset: 0x00048B80
		public unsafe Text water_Cost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_water_Cost);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_water_Cost), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F02 RID: 12034
		// (get) Token: 0x060099EC RID: 39404 RVA: 0x00277AB4 File Offset: 0x00275CB4
		// (set) Token: 0x060099ED RID: 39405 RVA: 0x0004A99F File Offset: 0x00048B9F
		public unsafe Text water_Total
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_water_Total);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_water_Total), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F03 RID: 12035
		// (get) Token: 0x060099EE RID: 39406 RVA: 0x00277AE4 File Offset: 0x00275CE4
		// (set) Token: 0x060099EF RID: 39407 RVA: 0x0004A9BE File Offset: 0x00048BBE
		public unsafe Text electricity_Usage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_electricity_Usage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_electricity_Usage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F04 RID: 12036
		// (get) Token: 0x060099F0 RID: 39408 RVA: 0x00277B14 File Offset: 0x00275D14
		// (set) Token: 0x060099F1 RID: 39409 RVA: 0x0004A9DD File Offset: 0x00048BDD
		public unsafe Text electricity_Cost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_electricity_Cost);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_electricity_Cost), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F05 RID: 12037
		// (get) Token: 0x060099F2 RID: 39410 RVA: 0x00277B44 File Offset: 0x00275D44
		// (set) Token: 0x060099F3 RID: 39411 RVA: 0x0004A9FC File Offset: 0x00048BFC
		public unsafe Text electricity_Total
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_electricity_Total);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_electricity_Total), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F06 RID: 12038
		// (get) Token: 0x060099F4 RID: 39412 RVA: 0x00277B74 File Offset: 0x00275D74
		// (set) Token: 0x060099F5 RID: 39413 RVA: 0x0004AA1B File Offset: 0x00048C1B
		public unsafe Text dumpster_Count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_dumpster_Count);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_dumpster_Count), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F07 RID: 12039
		// (get) Token: 0x060099F6 RID: 39414 RVA: 0x00277BA4 File Offset: 0x00275DA4
		// (set) Token: 0x060099F7 RID: 39415 RVA: 0x0004AA3A File Offset: 0x00048C3A
		public unsafe Text dumpster_EmptyCost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_dumpster_EmptyCost);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_dumpster_EmptyCost), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F08 RID: 12040
		// (get) Token: 0x060099F8 RID: 39416 RVA: 0x00277BD4 File Offset: 0x00275DD4
		// (set) Token: 0x060099F9 RID: 39417 RVA: 0x0004AA59 File Offset: 0x00048C59
		public unsafe Text dumpster_Total
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_dumpster_Total);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_dumpster_Total), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F09 RID: 12041
		// (get) Token: 0x060099FA RID: 39418 RVA: 0x00277C04 File Offset: 0x00275E04
		// (set) Token: 0x060099FB RID: 39419 RVA: 0x0004AA78 File Offset: 0x00048C78
		public unsafe Button dumpsterButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_dumpsterButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_dumpsterButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F0A RID: 12042
		// (get) Token: 0x060099FC RID: 39420 RVA: 0x00277C34 File Offset: 0x00275E34
		// (set) Token: 0x060099FD RID: 39421 RVA: 0x0004AA97 File Offset: 0x00048C97
		public unsafe PropertyDropdown propertySelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_propertySelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyDropdown>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_propertySelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F0B RID: 12043
		// (get) Token: 0x060099FE RID: 39422 RVA: 0x00277C64 File Offset: 0x00275E64
		// (set) Token: 0x060099FF RID: 39423 RVA: 0x0004AAB6 File Offset: 0x00048CB6
		public unsafe Property selectedProperty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_selectedProperty);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_selectedProperty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040067B0 RID: 26544
		private static readonly IntPtr NativeFieldInfoPtr_water_Usage;

		// Token: 0x040067B1 RID: 26545
		private static readonly IntPtr NativeFieldInfoPtr_water_Cost;

		// Token: 0x040067B2 RID: 26546
		private static readonly IntPtr NativeFieldInfoPtr_water_Total;

		// Token: 0x040067B3 RID: 26547
		private static readonly IntPtr NativeFieldInfoPtr_electricity_Usage;

		// Token: 0x040067B4 RID: 26548
		private static readonly IntPtr NativeFieldInfoPtr_electricity_Cost;

		// Token: 0x040067B5 RID: 26549
		private static readonly IntPtr NativeFieldInfoPtr_electricity_Total;

		// Token: 0x040067B6 RID: 26550
		private static readonly IntPtr NativeFieldInfoPtr_dumpster_Count;

		// Token: 0x040067B7 RID: 26551
		private static readonly IntPtr NativeFieldInfoPtr_dumpster_EmptyCost;

		// Token: 0x040067B8 RID: 26552
		private static readonly IntPtr NativeFieldInfoPtr_dumpster_Total;

		// Token: 0x040067B9 RID: 26553
		private static readonly IntPtr NativeFieldInfoPtr_dumpsterButton;

		// Token: 0x040067BA RID: 26554
		private static readonly IntPtr NativeFieldInfoPtr_propertySelector;

		// Token: 0x040067BB RID: 26555
		private static readonly IntPtr NativeFieldInfoPtr_selectedProperty;

		// Token: 0x040067BC RID: 26556
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040067BD RID: 26557
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x040067BE RID: 26558
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x040067BF RID: 26559
		private static readonly IntPtr NativeMethodInfoPtr_RefreshShownValues_Protected_Virtual_New_Void_0;

		// Token: 0x040067C0 RID: 26560
		private static readonly IntPtr NativeMethodInfoPtr_OnDayPass_Protected_Virtual_New_Void_0;

		// Token: 0x040067C1 RID: 26561
		private static readonly IntPtr NativeMethodInfoPtr_Round_Private_Single_Single_Single_0;

		// Token: 0x040067C2 RID: 26562
		private static readonly IntPtr NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0;

		// Token: 0x040067C3 RID: 26563
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
