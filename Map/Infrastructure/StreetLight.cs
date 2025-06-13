using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Lighting;
using UnityEngine;

namespace Il2CppScheduleOne.Map.Infrastructure
{
	// Token: 0x020007B6 RID: 1974
	public class StreetLight : MonoBehaviour
	{
		// Token: 0x0600BAB1 RID: 47793 RVA: 0x002E80C8 File Offset: 0x002E62C8
		// Note: this type is marked as 'beforefieldinit'.
		static StreetLight()
		{
			Il2CppClassPointerStore<StreetLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map.Infrastructure", "StreetLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StreetLight>.NativeClassPtr);
			StreetLight.NativeFieldInfoPtr_POWER_ORIGIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, "POWER_ORIGIN");
			StreetLight.NativeFieldInfoPtr_LightRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, "LightRend");
			StreetLight.NativeFieldInfoPtr_Light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, "Light");
			StreetLight.NativeFieldInfoPtr_BeamTracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, "BeamTracker");
			StreetLight.NativeFieldInfoPtr_LightOnMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, "LightOnMat");
			StreetLight.NativeFieldInfoPtr_LightOffMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, "LightOffMat");
			StreetLight.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, "StartTime");
			StreetLight.NativeFieldInfoPtr_EndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, "EndTime");
			StreetLight.NativeFieldInfoPtr_StartTimeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, "StartTimeOffset");
			StreetLight.NativeFieldInfoPtr_ShadowsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, "ShadowsEnabled");
			StreetLight.NativeFieldInfoPtr_LightMaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, "LightMaxDistance");
			StreetLight.NativeFieldInfoPtr_SoftShadowsThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, "SoftShadowsThreshold");
			StreetLight.NativeFieldInfoPtr_HardShadowsThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, "HardShadowsThreshold");
			StreetLight.NativeFieldInfoPtr_isOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, "isOn");
			StreetLight.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, 100686397);
			StreetLight.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, 100686398);
			StreetLight.NativeMethodInfoPtr_UpdateState_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, 100686399);
			StreetLight.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, 100686400);
			StreetLight.NativeMethodInfoPtr_SetState_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, 100686401);
			StreetLight.NativeMethodInfoPtr_UpdateShadows_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, 100686402);
			StreetLight.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, 100686403);
		}

		// Token: 0x0600BAB2 RID: 47794 RVA: 0x002E829C File Offset: 0x002E649C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317753, XrefRangeEnd = 317781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreetLight.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BAB3 RID: 47795 RVA: 0x002E82D8 File Offset: 0x002E64D8
		[CallerCount(0)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreetLight.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BAB4 RID: 47796 RVA: 0x002E830C File Offset: 0x002E650C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317781, XrefRangeEnd = 317793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreetLight.NativeMethodInfoPtr_UpdateState_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BAB5 RID: 47797 RVA: 0x002E8348 File Offset: 0x002E6548
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreetLight.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BAB6 RID: 47798 RVA: 0x002E837C File Offset: 0x002E657C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317820, RefRangeEnd = 317821, XrefRangeStart = 317793, XrefRangeEnd = 317820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetState(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref on;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreetLight.NativeMethodInfoPtr_SetState_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BAB7 RID: 47799 RVA: 0x002E83BC File Offset: 0x002E65BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317840, RefRangeEnd = 317841, XrefRangeStart = 317821, XrefRangeEnd = 317840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateShadows()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreetLight.NativeMethodInfoPtr_UpdateShadows_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BAB8 RID: 47800 RVA: 0x002E83F0 File Offset: 0x002E65F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317841, XrefRangeEnd = 317842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreetLight() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreetLight>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreetLight.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BAB9 RID: 47801 RVA: 0x0005B4FC File Offset: 0x000596FC
		public StreetLight(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700399A RID: 14746
		// (get) Token: 0x0600BABA RID: 47802 RVA: 0x002E842C File Offset: 0x002E662C
		// (set) Token: 0x0600BABB RID: 47803 RVA: 0x0005B505 File Offset: 0x00059705
		public unsafe static Vector3 POWER_ORIGIN
		{
			get
			{
				Vector3 result;
				IL2CPP.il2cpp_field_static_get_value(StreetLight.NativeFieldInfoPtr_POWER_ORIGIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StreetLight.NativeFieldInfoPtr_POWER_ORIGIN, (void*)(&value));
			}
		}

		// Token: 0x1700399B RID: 14747
		// (get) Token: 0x0600BABC RID: 47804 RVA: 0x002E8448 File Offset: 0x002E6648
		// (set) Token: 0x0600BABD RID: 47805 RVA: 0x0005B513 File Offset: 0x00059713
		public unsafe MeshRenderer LightRend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_LightRend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_LightRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700399C RID: 14748
		// (get) Token: 0x0600BABE RID: 47806 RVA: 0x002E8478 File Offset: 0x002E6678
		// (set) Token: 0x0600BABF RID: 47807 RVA: 0x0005B532 File Offset: 0x00059732
		public unsafe Light Light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_Light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_Light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700399D RID: 14749
		// (get) Token: 0x0600BAC0 RID: 47808 RVA: 0x002E84A8 File Offset: 0x002E66A8
		// (set) Token: 0x0600BAC1 RID: 47809 RVA: 0x0005B551 File Offset: 0x00059751
		public unsafe VolumetricLightTracker BeamTracker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_BeamTracker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricLightTracker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_BeamTracker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700399E RID: 14750
		// (get) Token: 0x0600BAC2 RID: 47810 RVA: 0x002E84D8 File Offset: 0x002E66D8
		// (set) Token: 0x0600BAC3 RID: 47811 RVA: 0x0005B570 File Offset: 0x00059770
		public unsafe Material LightOnMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_LightOnMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_LightOnMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700399F RID: 14751
		// (get) Token: 0x0600BAC4 RID: 47812 RVA: 0x002E8508 File Offset: 0x002E6708
		// (set) Token: 0x0600BAC5 RID: 47813 RVA: 0x0005B58F File Offset: 0x0005978F
		public unsafe Material LightOffMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_LightOffMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_LightOffMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039A0 RID: 14752
		// (get) Token: 0x0600BAC6 RID: 47814 RVA: 0x002E8538 File Offset: 0x002E6738
		// (set) Token: 0x0600BAC7 RID: 47815 RVA: 0x0005B5AE File Offset: 0x000597AE
		public unsafe int StartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_StartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_StartTime)) = value;
			}
		}

		// Token: 0x170039A1 RID: 14753
		// (get) Token: 0x0600BAC8 RID: 47816 RVA: 0x002E8560 File Offset: 0x002E6760
		// (set) Token: 0x0600BAC9 RID: 47817 RVA: 0x0005B5C9 File Offset: 0x000597C9
		public unsafe int EndTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_EndTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_EndTime)) = value;
			}
		}

		// Token: 0x170039A2 RID: 14754
		// (get) Token: 0x0600BACA RID: 47818 RVA: 0x002E8588 File Offset: 0x002E6788
		// (set) Token: 0x0600BACB RID: 47819 RVA: 0x0005B5E4 File Offset: 0x000597E4
		public unsafe int StartTimeOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_StartTimeOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_StartTimeOffset)) = value;
			}
		}

		// Token: 0x170039A3 RID: 14755
		// (get) Token: 0x0600BACC RID: 47820 RVA: 0x002E85B0 File Offset: 0x002E67B0
		// (set) Token: 0x0600BACD RID: 47821 RVA: 0x0005B5FF File Offset: 0x000597FF
		public unsafe bool ShadowsEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_ShadowsEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_ShadowsEnabled)) = value;
			}
		}

		// Token: 0x170039A4 RID: 14756
		// (get) Token: 0x0600BACE RID: 47822 RVA: 0x002E85D8 File Offset: 0x002E67D8
		// (set) Token: 0x0600BACF RID: 47823 RVA: 0x0005B61A File Offset: 0x0005981A
		public unsafe float LightMaxDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_LightMaxDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_LightMaxDistance)) = value;
			}
		}

		// Token: 0x170039A5 RID: 14757
		// (get) Token: 0x0600BAD0 RID: 47824 RVA: 0x002E8600 File Offset: 0x002E6800
		// (set) Token: 0x0600BAD1 RID: 47825 RVA: 0x0005B635 File Offset: 0x00059835
		public unsafe float SoftShadowsThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_SoftShadowsThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_SoftShadowsThreshold)) = value;
			}
		}

		// Token: 0x170039A6 RID: 14758
		// (get) Token: 0x0600BAD2 RID: 47826 RVA: 0x002E8628 File Offset: 0x002E6828
		// (set) Token: 0x0600BAD3 RID: 47827 RVA: 0x0005B650 File Offset: 0x00059850
		public unsafe float HardShadowsThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_HardShadowsThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_HardShadowsThreshold)) = value;
			}
		}

		// Token: 0x170039A7 RID: 14759
		// (get) Token: 0x0600BAD4 RID: 47828 RVA: 0x002E8650 File Offset: 0x002E6850
		// (set) Token: 0x0600BAD5 RID: 47829 RVA: 0x0005B66B File Offset: 0x0005986B
		public unsafe bool isOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_isOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_isOn)) = value;
			}
		}

		// Token: 0x04007DE3 RID: 32227
		private static readonly IntPtr NativeFieldInfoPtr_POWER_ORIGIN;

		// Token: 0x04007DE4 RID: 32228
		private static readonly IntPtr NativeFieldInfoPtr_LightRend;

		// Token: 0x04007DE5 RID: 32229
		private static readonly IntPtr NativeFieldInfoPtr_Light;

		// Token: 0x04007DE6 RID: 32230
		private static readonly IntPtr NativeFieldInfoPtr_BeamTracker;

		// Token: 0x04007DE7 RID: 32231
		private static readonly IntPtr NativeFieldInfoPtr_LightOnMat;

		// Token: 0x04007DE8 RID: 32232
		private static readonly IntPtr NativeFieldInfoPtr_LightOffMat;

		// Token: 0x04007DE9 RID: 32233
		private static readonly IntPtr NativeFieldInfoPtr_StartTime;

		// Token: 0x04007DEA RID: 32234
		private static readonly IntPtr NativeFieldInfoPtr_EndTime;

		// Token: 0x04007DEB RID: 32235
		private static readonly IntPtr NativeFieldInfoPtr_StartTimeOffset;

		// Token: 0x04007DEC RID: 32236
		private static readonly IntPtr NativeFieldInfoPtr_ShadowsEnabled;

		// Token: 0x04007DED RID: 32237
		private static readonly IntPtr NativeFieldInfoPtr_LightMaxDistance;

		// Token: 0x04007DEE RID: 32238
		private static readonly IntPtr NativeFieldInfoPtr_SoftShadowsThreshold;

		// Token: 0x04007DEF RID: 32239
		private static readonly IntPtr NativeFieldInfoPtr_HardShadowsThreshold;

		// Token: 0x04007DF0 RID: 32240
		private static readonly IntPtr NativeFieldInfoPtr_isOn;

		// Token: 0x04007DF1 RID: 32241
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04007DF2 RID: 32242
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04007DF3 RID: 32243
		private static readonly IntPtr NativeMethodInfoPtr_UpdateState_Protected_Virtual_New_Void_0;

		// Token: 0x04007DF4 RID: 32244
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x04007DF5 RID: 32245
		private static readonly IntPtr NativeMethodInfoPtr_SetState_Private_Void_Boolean_0;

		// Token: 0x04007DF6 RID: 32246
		private static readonly IntPtr NativeMethodInfoPtr_UpdateShadows_Private_Void_0;

		// Token: 0x04007DF7 RID: 32247
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
