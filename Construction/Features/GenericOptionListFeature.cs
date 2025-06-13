using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.UI.Construction.Features;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Construction.Features
{
	// Token: 0x020004A7 RID: 1191
	public class GenericOptionListFeature : OptionListFeature
	{
		// Token: 0x06006652 RID: 26194 RVA: 0x001D09F4 File Offset: 0x001CEBF4
		// Note: this type is marked as 'beforefieldinit'.
		static GenericOptionListFeature()
		{
			Il2CppClassPointerStore<GenericOptionListFeature>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Construction.Features", "GenericOptionListFeature");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericOptionListFeature>.NativeClassPtr);
			GenericOptionListFeature.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericOptionListFeature>.NativeClassPtr, "options");
			GenericOptionListFeature.NativeFieldInfoPtr_visibleOption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericOptionListFeature>.NativeClassPtr, "visibleOption");
			GenericOptionListFeature.NativeFieldInfoPtr_installedOption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericOptionListFeature>.NativeClassPtr, "installedOption");
			GenericOptionListFeature.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericOptionListFeature>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Construction.Features.GenericOptionListFeatureAssembly-CSharp.dll_Excuted");
			GenericOptionListFeature.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericOptionListFeature>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Construction.Features.GenericOptionListFeatureAssembly-CSharp.dll_Excuted");
			GenericOptionListFeature.NativeMethodInfoPtr_Default_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericOptionListFeature>.NativeClassPtr, 100676352);
			GenericOptionListFeature.NativeMethodInfoPtr_GetOptions_Protected_Virtual_List_1_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericOptionListFeature>.NativeClassPtr, 100676353);
			GenericOptionListFeature.NativeMethodInfoPtr_SelectOption_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericOptionListFeature>.NativeClassPtr, 100676354);
			GenericOptionListFeature.NativeMethodInfoPtr_PurchaseOption_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericOptionListFeature>.NativeClassPtr, 100676355);
			GenericOptionListFeature.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericOptionListFeature>.NativeClassPtr, 100676356);
			GenericOptionListFeature.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericOptionListFeature>.NativeClassPtr, 100676357);
			GenericOptionListFeature.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericOptionListFeature>.NativeClassPtr, 100676358);
			GenericOptionListFeature.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericOptionListFeature>.NativeClassPtr, 100676359);
			GenericOptionListFeature.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericOptionListFeature>.NativeClassPtr, 100676360);
		}

		// Token: 0x06006653 RID: 26195 RVA: 0x001D0B3C File Offset: 0x001CED3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208743, XrefRangeEnd = 208749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Default()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericOptionListFeature.NativeMethodInfoPtr_Default_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006654 RID: 26196 RVA: 0x001D0B78 File Offset: 0x001CED78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208749, XrefRangeEnd = 208778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override List<FI_OptionList.Option> GetOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericOptionListFeature.NativeMethodInfoPtr_GetOptions_Protected_Virtual_List_1_Option_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FI_OptionList.Option>>(intPtr2) : null;
		}

		// Token: 0x06006655 RID: 26197 RVA: 0x001D0BC4 File Offset: 0x001CEDC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208778, XrefRangeEnd = 208792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SelectOption(int optionIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref optionIndex;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericOptionListFeature.NativeMethodInfoPtr_SelectOption_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006656 RID: 26198 RVA: 0x001D0C10 File Offset: 0x001CEE10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208792, XrefRangeEnd = 208806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PurchaseOption(int optionIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref optionIndex;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericOptionListFeature.NativeMethodInfoPtr_PurchaseOption_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006657 RID: 26199 RVA: 0x001D0C5C File Offset: 0x001CEE5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208806, XrefRangeEnd = 208818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericOptionListFeature() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericOptionListFeature>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericOptionListFeature.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006658 RID: 26200 RVA: 0x001D0C98 File Offset: 0x001CEE98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208818, XrefRangeEnd = 208819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericOptionListFeature.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006659 RID: 26201 RVA: 0x001D0CD4 File Offset: 0x001CEED4
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericOptionListFeature.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600665A RID: 26202 RVA: 0x001D0D10 File Offset: 0x001CEF10
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericOptionListFeature.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600665B RID: 26203 RVA: 0x001D0D4C File Offset: 0x001CEF4C
		[CallerCount(0)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericOptionListFeature.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600665C RID: 26204 RVA: 0x000302BC File Offset: 0x0002E4BC
		public GenericOptionListFeature(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EA8 RID: 7848
		// (get) Token: 0x0600665D RID: 26205 RVA: 0x001D0D88 File Offset: 0x001CEF88
		// (set) Token: 0x0600665E RID: 26206 RVA: 0x000302C5 File Offset: 0x0002E4C5
		public unsafe List<GenericOption> options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOptionListFeature.NativeFieldInfoPtr_options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GenericOption>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOptionListFeature.NativeFieldInfoPtr_options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EA9 RID: 7849
		// (get) Token: 0x0600665F RID: 26207 RVA: 0x001D0DB8 File Offset: 0x001CEFB8
		// (set) Token: 0x06006660 RID: 26208 RVA: 0x000302E4 File Offset: 0x0002E4E4
		public unsafe GenericOption visibleOption
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOptionListFeature.NativeFieldInfoPtr_visibleOption);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenericOption>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOptionListFeature.NativeFieldInfoPtr_visibleOption), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EAA RID: 7850
		// (get) Token: 0x06006661 RID: 26209 RVA: 0x001D0DE8 File Offset: 0x001CEFE8
		// (set) Token: 0x06006662 RID: 26210 RVA: 0x00030303 File Offset: 0x0002E503
		public unsafe GenericOption installedOption
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOptionListFeature.NativeFieldInfoPtr_installedOption);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenericOption>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOptionListFeature.NativeFieldInfoPtr_installedOption), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EAB RID: 7851
		// (get) Token: 0x06006663 RID: 26211 RVA: 0x001D0E18 File Offset: 0x001CF018
		// (set) Token: 0x06006664 RID: 26212 RVA: 0x00030322 File Offset: 0x0002E522
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOptionListFeature.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOptionListFeature.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001EAC RID: 7852
		// (get) Token: 0x06006665 RID: 26213 RVA: 0x001D0E40 File Offset: 0x001CF040
		// (set) Token: 0x06006666 RID: 26214 RVA: 0x0003033D File Offset: 0x0002E53D
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOptionListFeature.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOptionListFeature.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040045D3 RID: 17875
		private static readonly IntPtr NativeFieldInfoPtr_options;

		// Token: 0x040045D4 RID: 17876
		private static readonly IntPtr NativeFieldInfoPtr_visibleOption;

		// Token: 0x040045D5 RID: 17877
		private static readonly IntPtr NativeFieldInfoPtr_installedOption;

		// Token: 0x040045D6 RID: 17878
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040045D7 RID: 17879
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040045D8 RID: 17880
		private static readonly IntPtr NativeMethodInfoPtr_Default_Public_Virtual_Void_0;

		// Token: 0x040045D9 RID: 17881
		private static readonly IntPtr NativeMethodInfoPtr_GetOptions_Protected_Virtual_List_1_Option_0;

		// Token: 0x040045DA RID: 17882
		private static readonly IntPtr NativeMethodInfoPtr_SelectOption_Public_Virtual_Void_Int32_0;

		// Token: 0x040045DB RID: 17883
		private static readonly IntPtr NativeMethodInfoPtr_PurchaseOption_Public_Virtual_Void_Int32_0;

		// Token: 0x040045DC RID: 17884
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040045DD RID: 17885
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040045DE RID: 17886
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040045DF RID: 17887
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040045E0 RID: 17888
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
