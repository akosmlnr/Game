using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Management.Settings
{
	// Token: 0x020003CA RID: 970
	[System.Serializable]
	public class ItemSelectionSetting : Il2CppSystem.Object
	{
		// Token: 0x06004AC8 RID: 19144 RVA: 0x0016DDD0 File Offset: 0x0016BFD0
		// Note: this type is marked as 'beforefieldinit'.
		static ItemSelectionSetting()
		{
			Il2CppClassPointerStore<ItemSelectionSetting>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management.Settings", "ItemSelectionSetting");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSelectionSetting>.NativeClassPtr);
			ItemSelectionSetting.NativeFieldInfoPtr__SelectedItems_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSelectionSetting>.NativeClassPtr, "<SelectedItems>k__BackingField");
			ItemSelectionSetting.NativeMethodInfoPtr_get_SelectedItems_Public_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelectionSetting>.NativeClassPtr, 100672647);
			ItemSelectionSetting.NativeMethodInfoPtr_set_SelectedItems_Protected_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelectionSetting>.NativeClassPtr, 100672648);
			ItemSelectionSetting.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelectionSetting>.NativeClassPtr, 100672649);
		}

		// Token: 0x17001649 RID: 5705
		// (get) Token: 0x06004AC9 RID: 19145 RVA: 0x0016DE50 File Offset: 0x0016C050
		// (set) Token: 0x06004ACA RID: 19146 RVA: 0x0016DE90 File Offset: 0x0016C090
		public unsafe List<string> SelectedItems
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 18697, RefRangeEnd = 18709, XrefRangeStart = 18697, XrefRangeEnd = 18709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSelectionSetting.NativeMethodInfoPtr_get_SelectedItems_Public_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 31460, RefRangeEnd = 31462, XrefRangeStart = 31460, XrefRangeEnd = 31462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSelectionSetting.NativeMethodInfoPtr_set_SelectedItems_Protected_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06004ACB RID: 19147 RVA: 0x0016DED4 File Offset: 0x0016C0D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167756, XrefRangeEnd = 167764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSelectionSetting() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSelectionSetting>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSelectionSetting.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004ACC RID: 19148 RVA: 0x00023DA2 File Offset: 0x00021FA2
		public ItemSelectionSetting(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001648 RID: 5704
		// (get) Token: 0x06004ACD RID: 19149 RVA: 0x0016DF10 File Offset: 0x0016C110
		// (set) Token: 0x06004ACE RID: 19150 RVA: 0x00023DAB File Offset: 0x00021FAB
		public unsafe List<string> _SelectedItems_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelectionSetting.NativeFieldInfoPtr__SelectedItems_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelectionSetting.NativeFieldInfoPtr__SelectedItems_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400326A RID: 12906
		private static readonly System.IntPtr NativeFieldInfoPtr__SelectedItems_k__BackingField;

		// Token: 0x0400326B RID: 12907
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SelectedItems_Public_get_List_1_String_0;

		// Token: 0x0400326C RID: 12908
		private static readonly System.IntPtr NativeMethodInfoPtr_set_SelectedItems_Protected_set_Void_List_1_String_0;

		// Token: 0x0400326D RID: 12909
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
