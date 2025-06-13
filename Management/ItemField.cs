using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020003B3 RID: 947
	public class ItemField : ConfigField
	{
		// Token: 0x06004946 RID: 18758 RVA: 0x001682B0 File Offset: 0x001664B0
		// Note: this type is marked as 'beforefieldinit'.
		static ItemField()
		{
			Il2CppClassPointerStore<ItemField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "ItemField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemField>.NativeClassPtr);
			ItemField.NativeFieldInfoPtr__SelectedItem_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemField>.NativeClassPtr, "<SelectedItem>k__BackingField");
			ItemField.NativeFieldInfoPtr_CanSelectNone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemField>.NativeClassPtr, "CanSelectNone");
			ItemField.NativeFieldInfoPtr_Options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemField>.NativeClassPtr, "Options");
			ItemField.NativeFieldInfoPtr_onItemChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemField>.NativeClassPtr, "onItemChanged");
			ItemField.NativeMethodInfoPtr_get_SelectedItem_Public_get_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemField>.NativeClassPtr, 100672434);
			ItemField.NativeMethodInfoPtr_set_SelectedItem_Protected_set_Void_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemField>.NativeClassPtr, 100672435);
			ItemField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemField>.NativeClassPtr, 100672436);
			ItemField.NativeMethodInfoPtr_SetItem_Public_Void_ItemDefinition_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemField>.NativeClassPtr, 100672437);
			ItemField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemField>.NativeClassPtr, 100672438);
			ItemField.NativeMethodInfoPtr_GetData_Public_ItemFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemField>.NativeClassPtr, 100672439);
			ItemField.NativeMethodInfoPtr_Load_Public_Void_ItemFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemField>.NativeClassPtr, 100672440);
		}

		// Token: 0x170015D9 RID: 5593
		// (get) Token: 0x06004947 RID: 18759 RVA: 0x001683BC File Offset: 0x001665BC
		// (set) Token: 0x06004948 RID: 18760 RVA: 0x001683FC File Offset: 0x001665FC
		public unsafe ItemDefinition SelectedItem
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemField.NativeMethodInfoPtr_get_SelectedItem_Public_get_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemField.NativeMethodInfoPtr_set_SelectedItem_Protected_set_Void_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06004949 RID: 18761 RVA: 0x00168440 File Offset: 0x00166640
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 165932, RefRangeEnd = 165936, XrefRangeStart = 165917, XrefRangeEnd = 165932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemField(EntityConfiguration parentConfig) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemField>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentConfig);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600494A RID: 18762 RVA: 0x0016848C File Offset: 0x0016668C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 165941, RefRangeEnd = 165943, XrefRangeStart = 165936, XrefRangeEnd = 165941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetItem(ItemDefinition item, bool network)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemField.NativeMethodInfoPtr_SetItem_Public_Void_ItemDefinition_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600494B RID: 18763 RVA: 0x001684DC File Offset: 0x001666DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165943, XrefRangeEnd = 165947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsValueDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600494C RID: 18764 RVA: 0x00168524 File Offset: 0x00166724
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 165958, RefRangeEnd = 165962, XrefRangeStart = 165947, XrefRangeEnd = 165958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemFieldData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemField.NativeMethodInfoPtr_GetData_Public_ItemFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemFieldData>(intPtr2) : null;
		}

		// Token: 0x0600494D RID: 18765 RVA: 0x00168564 File Offset: 0x00166764
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 165969, RefRangeEnd = 165977, XrefRangeStart = 165962, XrefRangeEnd = 165969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(ItemFieldData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemField.NativeMethodInfoPtr_Load_Public_Void_ItemFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600494E RID: 18766 RVA: 0x00023446 File Offset: 0x00021646
		public ItemField(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170015D5 RID: 5589
		// (get) Token: 0x0600494F RID: 18767 RVA: 0x001685A8 File Offset: 0x001667A8
		// (set) Token: 0x06004950 RID: 18768 RVA: 0x0002344F File Offset: 0x0002164F
		public unsafe ItemDefinition _SelectedItem_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemField.NativeFieldInfoPtr__SelectedItem_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemField.NativeFieldInfoPtr__SelectedItem_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015D6 RID: 5590
		// (get) Token: 0x06004951 RID: 18769 RVA: 0x001685D8 File Offset: 0x001667D8
		// (set) Token: 0x06004952 RID: 18770 RVA: 0x0002346E File Offset: 0x0002166E
		public unsafe bool CanSelectNone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemField.NativeFieldInfoPtr_CanSelectNone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemField.NativeFieldInfoPtr_CanSelectNone)) = value;
			}
		}

		// Token: 0x170015D7 RID: 5591
		// (get) Token: 0x06004953 RID: 18771 RVA: 0x00168600 File Offset: 0x00166800
		// (set) Token: 0x06004954 RID: 18772 RVA: 0x00023489 File Offset: 0x00021689
		public unsafe List<ItemDefinition> Options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemField.NativeFieldInfoPtr_Options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemField.NativeFieldInfoPtr_Options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015D8 RID: 5592
		// (get) Token: 0x06004955 RID: 18773 RVA: 0x00168630 File Offset: 0x00166830
		// (set) Token: 0x06004956 RID: 18774 RVA: 0x000234A8 File Offset: 0x000216A8
		public unsafe UnityEvent<ItemDefinition> onItemChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemField.NativeFieldInfoPtr_onItemChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<ItemDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemField.NativeFieldInfoPtr_onItemChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400315B RID: 12635
		private static readonly IntPtr NativeFieldInfoPtr__SelectedItem_k__BackingField;

		// Token: 0x0400315C RID: 12636
		private static readonly IntPtr NativeFieldInfoPtr_CanSelectNone;

		// Token: 0x0400315D RID: 12637
		private static readonly IntPtr NativeFieldInfoPtr_Options;

		// Token: 0x0400315E RID: 12638
		private static readonly IntPtr NativeFieldInfoPtr_onItemChanged;

		// Token: 0x0400315F RID: 12639
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedItem_Public_get_ItemDefinition_0;

		// Token: 0x04003160 RID: 12640
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectedItem_Protected_set_Void_ItemDefinition_0;

		// Token: 0x04003161 RID: 12641
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0;

		// Token: 0x04003162 RID: 12642
		private static readonly IntPtr NativeMethodInfoPtr_SetItem_Public_Void_ItemDefinition_Boolean_0;

		// Token: 0x04003163 RID: 12643
		private static readonly IntPtr NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0;

		// Token: 0x04003164 RID: 12644
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_ItemFieldData_0;

		// Token: 0x04003165 RID: 12645
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_ItemFieldData_0;
	}
}
