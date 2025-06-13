using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003F5 RID: 1013
	[System.Serializable]
	public class CurfewInstance : Il2CppSystem.Object
	{
		// Token: 0x06004D07 RID: 19719 RVA: 0x001754C4 File Offset: 0x001736C4
		// Note: this type is marked as 'beforefieldinit'.
		static CurfewInstance()
		{
			Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "CurfewInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr);
			CurfewInstance.NativeFieldInfoPtr_ActiveInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr, "ActiveInstance");
			CurfewInstance.NativeFieldInfoPtr_IntensityRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr, "IntensityRequirement");
			CurfewInstance.NativeFieldInfoPtr__Enabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr, "<Enabled>k__BackingField");
			CurfewInstance.NativeFieldInfoPtr_shouldDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr, "shouldDisable");
			CurfewInstance.NativeMethodInfoPtr_get_Enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr, 100672914);
			CurfewInstance.NativeMethodInfoPtr_set_Enabled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr, 100672915);
			CurfewInstance.NativeMethodInfoPtr_Evaluate_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr, 100672916);
			CurfewInstance.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr, 100672917);
			CurfewInstance.NativeMethodInfoPtr_Enable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr, 100672918);
			CurfewInstance.NativeMethodInfoPtr_Disable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr, 100672919);
			CurfewInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr, 100672920);
		}

		// Token: 0x170016F4 RID: 5876
		// (get) Token: 0x06004D08 RID: 19720 RVA: 0x001755D0 File Offset: 0x001737D0
		// (set) Token: 0x06004D09 RID: 19721 RVA: 0x0017560C File Offset: 0x0017380C
		public unsafe bool Enabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CurfewInstance.NativeMethodInfoPtr_get_Enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewInstance.NativeMethodInfoPtr_set_Enabled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06004D0A RID: 19722 RVA: 0x0017564C File Offset: 0x0017384C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 169395, RefRangeEnd = 169398, XrefRangeStart = 169387, XrefRangeEnd = 169395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Evaluate(bool ignoreSleepReq = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref ignoreSleepReq;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewInstance.NativeMethodInfoPtr_Evaluate_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004D0B RID: 19723 RVA: 0x0017568C File Offset: 0x0017388C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169398, XrefRangeEnd = 169406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewInstance.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004D0C RID: 19724 RVA: 0x001756C0 File Offset: 0x001738C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169433, RefRangeEnd = 169434, XrefRangeStart = 169406, XrefRangeEnd = 169433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewInstance.NativeMethodInfoPtr_Enable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004D0D RID: 19725 RVA: 0x001756F4 File Offset: 0x001738F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169456, RefRangeEnd = 169457, XrefRangeStart = 169434, XrefRangeEnd = 169456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewInstance.NativeMethodInfoPtr_Disable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004D0E RID: 19726 RVA: 0x00175728 File Offset: 0x00173928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169457, XrefRangeEnd = 169458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CurfewInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004D0F RID: 19727 RVA: 0x00024DCE File Offset: 0x00022FCE
		public CurfewInstance(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016F0 RID: 5872
		// (get) Token: 0x06004D10 RID: 19728 RVA: 0x00175764 File Offset: 0x00173964
		// (set) Token: 0x06004D11 RID: 19729 RVA: 0x00024DD7 File Offset: 0x00022FD7
		public unsafe static CurfewInstance ActiveInstance
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CurfewInstance.NativeFieldInfoPtr_ActiveInstance, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CurfewInstance>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CurfewInstance.NativeFieldInfoPtr_ActiveInstance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016F1 RID: 5873
		// (get) Token: 0x06004D12 RID: 19730 RVA: 0x0017578C File Offset: 0x0017398C
		// (set) Token: 0x06004D13 RID: 19731 RVA: 0x00024DE9 File Offset: 0x00022FE9
		public unsafe int IntensityRequirement
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewInstance.NativeFieldInfoPtr_IntensityRequirement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewInstance.NativeFieldInfoPtr_IntensityRequirement)) = value;
			}
		}

		// Token: 0x170016F2 RID: 5874
		// (get) Token: 0x06004D14 RID: 19732 RVA: 0x001757B4 File Offset: 0x001739B4
		// (set) Token: 0x06004D15 RID: 19733 RVA: 0x00024E04 File Offset: 0x00023004
		public unsafe bool _Enabled_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewInstance.NativeFieldInfoPtr__Enabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewInstance.NativeFieldInfoPtr__Enabled_k__BackingField)) = value;
			}
		}

		// Token: 0x170016F3 RID: 5875
		// (get) Token: 0x06004D16 RID: 19734 RVA: 0x001757DC File Offset: 0x001739DC
		// (set) Token: 0x06004D17 RID: 19735 RVA: 0x00024E1F File Offset: 0x0002301F
		public unsafe bool shouldDisable
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewInstance.NativeFieldInfoPtr_shouldDisable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewInstance.NativeFieldInfoPtr_shouldDisable)) = value;
			}
		}

		// Token: 0x040033E4 RID: 13284
		private static readonly System.IntPtr NativeFieldInfoPtr_ActiveInstance;

		// Token: 0x040033E5 RID: 13285
		private static readonly System.IntPtr NativeFieldInfoPtr_IntensityRequirement;

		// Token: 0x040033E6 RID: 13286
		private static readonly System.IntPtr NativeFieldInfoPtr__Enabled_k__BackingField;

		// Token: 0x040033E7 RID: 13287
		private static readonly System.IntPtr NativeFieldInfoPtr_shouldDisable;

		// Token: 0x040033E8 RID: 13288
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Enabled_Public_get_Boolean_0;

		// Token: 0x040033E9 RID: 13289
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Enabled_Protected_set_Void_Boolean_0;

		// Token: 0x040033EA RID: 13290
		private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Public_Void_Boolean_0;

		// Token: 0x040033EB RID: 13291
		private static readonly System.IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x040033EC RID: 13292
		private static readonly System.IntPtr NativeMethodInfoPtr_Enable_Public_Void_0;

		// Token: 0x040033ED RID: 13293
		private static readonly System.IntPtr NativeMethodInfoPtr_Disable_Public_Void_0;

		// Token: 0x040033EE RID: 13294
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
