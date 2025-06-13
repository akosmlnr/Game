using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Management.Presets.Options
{
	// Token: 0x020003CF RID: 975
	public class ItemList : Option
	{
		// Token: 0x06004B1B RID: 19227 RVA: 0x0016EF60 File Offset: 0x0016D160
		// Note: this type is marked as 'beforefieldinit'.
		static ItemList()
		{
			Il2CppClassPointerStore<ItemList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management.Presets.Options", "ItemList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemList>.NativeClassPtr);
			ItemList.NativeFieldInfoPtr_All = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemList>.NativeClassPtr, "All");
			ItemList.NativeFieldInfoPtr_None = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemList>.NativeClassPtr, "None");
			ItemList.NativeFieldInfoPtr_Selection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemList>.NativeClassPtr, "Selection");
			ItemList.NativeFieldInfoPtr__CanBeAll_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemList>.NativeClassPtr, "<CanBeAll>k__BackingField");
			ItemList.NativeFieldInfoPtr__CanBeNone_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemList>.NativeClassPtr, "<CanBeNone>k__BackingField");
			ItemList.NativeFieldInfoPtr__OptionList_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemList>.NativeClassPtr, "<OptionList>k__BackingField");
			ItemList.NativeMethodInfoPtr_get_CanBeAll_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemList>.NativeClassPtr, 100672695);
			ItemList.NativeMethodInfoPtr_set_CanBeAll_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemList>.NativeClassPtr, 100672696);
			ItemList.NativeMethodInfoPtr_get_CanBeNone_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemList>.NativeClassPtr, 100672697);
			ItemList.NativeMethodInfoPtr_set_CanBeNone_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemList>.NativeClassPtr, 100672698);
			ItemList.NativeMethodInfoPtr_get_OptionList_Public_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemList>.NativeClassPtr, 100672699);
			ItemList.NativeMethodInfoPtr_set_OptionList_Protected_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemList>.NativeClassPtr, 100672700);
			ItemList.NativeMethodInfoPtr__ctor_Public_Void_String_List_1_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemList>.NativeClassPtr, 100672701);
			ItemList.NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemList>.NativeClassPtr, 100672702);
			ItemList.NativeMethodInfoPtr_GetDisplayString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemList>.NativeClassPtr, 100672703);
		}

		// Token: 0x17001665 RID: 5733
		// (get) Token: 0x06004B1C RID: 19228 RVA: 0x0016F0BC File Offset: 0x0016D2BC
		// (set) Token: 0x06004B1D RID: 19229 RVA: 0x0016F0F8 File Offset: 0x0016D2F8
		public unsafe bool CanBeAll
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ItemList.NativeMethodInfoPtr_get_CanBeAll_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 40119, RefRangeEnd = 40138, XrefRangeStart = 40119, XrefRangeEnd = 40138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemList.NativeMethodInfoPtr_set_CanBeAll_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001666 RID: 5734
		// (get) Token: 0x06004B1E RID: 19230 RVA: 0x0016F138 File Offset: 0x0016D338
		// (set) Token: 0x06004B1F RID: 19231 RVA: 0x0016F174 File Offset: 0x0016D374
		public unsafe bool CanBeNone
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ItemList.NativeMethodInfoPtr_get_CanBeNone_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemList.NativeMethodInfoPtr_set_CanBeNone_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001667 RID: 5735
		// (get) Token: 0x06004B20 RID: 19232 RVA: 0x0016F1B4 File Offset: 0x0016D3B4
		// (set) Token: 0x06004B21 RID: 19233 RVA: 0x0016F1F4 File Offset: 0x0016D3F4
		public unsafe List<string> OptionList
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 20988, RefRangeEnd = 21002, XrefRangeStart = 20988, XrefRangeEnd = 21002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemList.NativeMethodInfoPtr_get_OptionList_Public_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 21003, RefRangeEnd = 21004, XrefRangeStart = 21003, XrefRangeEnd = 21004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemList.NativeMethodInfoPtr_set_OptionList_Protected_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06004B22 RID: 19234 RVA: 0x0016F238 File Offset: 0x0016D438
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 168105, RefRangeEnd = 168107, XrefRangeStart = 168084, XrefRangeEnd = 168105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemList(string name, List<string> optionList, bool canBeAll, bool canBeNone) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemList>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(optionList);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canBeAll;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canBeNone;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemList.NativeMethodInfoPtr__ctor_Public_Void_String_List_1_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004B23 RID: 19235 RVA: 0x0016F2B4 File Offset: 0x0016D4B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168107, XrefRangeEnd = 168123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CopyTo(Option other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemList.NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Option_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004B24 RID: 19236 RVA: 0x0016F304 File Offset: 0x0016D504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168123, XrefRangeEnd = 168146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetDisplayString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemList.NativeMethodInfoPtr_GetDisplayString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06004B25 RID: 19237 RVA: 0x00024007 File Offset: 0x00022207
		public ItemList(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700165F RID: 5727
		// (get) Token: 0x06004B26 RID: 19238 RVA: 0x0016F348 File Offset: 0x0016D548
		// (set) Token: 0x06004B27 RID: 19239 RVA: 0x00024010 File Offset: 0x00022210
		public unsafe bool All
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemList.NativeFieldInfoPtr_All);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemList.NativeFieldInfoPtr_All)) = value;
			}
		}

		// Token: 0x17001660 RID: 5728
		// (get) Token: 0x06004B28 RID: 19240 RVA: 0x0016F370 File Offset: 0x0016D570
		// (set) Token: 0x06004B29 RID: 19241 RVA: 0x0002402B File Offset: 0x0002222B
		public unsafe bool None
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemList.NativeFieldInfoPtr_None);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemList.NativeFieldInfoPtr_None)) = value;
			}
		}

		// Token: 0x17001661 RID: 5729
		// (get) Token: 0x06004B2A RID: 19242 RVA: 0x0016F398 File Offset: 0x0016D598
		// (set) Token: 0x06004B2B RID: 19243 RVA: 0x00024046 File Offset: 0x00022246
		public unsafe List<string> Selection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemList.NativeFieldInfoPtr_Selection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemList.NativeFieldInfoPtr_Selection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001662 RID: 5730
		// (get) Token: 0x06004B2C RID: 19244 RVA: 0x0016F3C8 File Offset: 0x0016D5C8
		// (set) Token: 0x06004B2D RID: 19245 RVA: 0x00024065 File Offset: 0x00022265
		public unsafe bool _CanBeAll_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemList.NativeFieldInfoPtr__CanBeAll_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemList.NativeFieldInfoPtr__CanBeAll_k__BackingField)) = value;
			}
		}

		// Token: 0x17001663 RID: 5731
		// (get) Token: 0x06004B2E RID: 19246 RVA: 0x0016F3F0 File Offset: 0x0016D5F0
		// (set) Token: 0x06004B2F RID: 19247 RVA: 0x00024080 File Offset: 0x00022280
		public unsafe bool _CanBeNone_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemList.NativeFieldInfoPtr__CanBeNone_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemList.NativeFieldInfoPtr__CanBeNone_k__BackingField)) = value;
			}
		}

		// Token: 0x17001664 RID: 5732
		// (get) Token: 0x06004B30 RID: 19248 RVA: 0x0016F418 File Offset: 0x0016D618
		// (set) Token: 0x06004B31 RID: 19249 RVA: 0x0002409B File Offset: 0x0002229B
		public unsafe List<string> _OptionList_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemList.NativeFieldInfoPtr__OptionList_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemList.NativeFieldInfoPtr__OptionList_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040032A0 RID: 12960
		private static readonly IntPtr NativeFieldInfoPtr_All;

		// Token: 0x040032A1 RID: 12961
		private static readonly IntPtr NativeFieldInfoPtr_None;

		// Token: 0x040032A2 RID: 12962
		private static readonly IntPtr NativeFieldInfoPtr_Selection;

		// Token: 0x040032A3 RID: 12963
		private static readonly IntPtr NativeFieldInfoPtr__CanBeAll_k__BackingField;

		// Token: 0x040032A4 RID: 12964
		private static readonly IntPtr NativeFieldInfoPtr__CanBeNone_k__BackingField;

		// Token: 0x040032A5 RID: 12965
		private static readonly IntPtr NativeFieldInfoPtr__OptionList_k__BackingField;

		// Token: 0x040032A6 RID: 12966
		private static readonly IntPtr NativeMethodInfoPtr_get_CanBeAll_Public_get_Boolean_0;

		// Token: 0x040032A7 RID: 12967
		private static readonly IntPtr NativeMethodInfoPtr_set_CanBeAll_Protected_set_Void_Boolean_0;

		// Token: 0x040032A8 RID: 12968
		private static readonly IntPtr NativeMethodInfoPtr_get_CanBeNone_Public_get_Boolean_0;

		// Token: 0x040032A9 RID: 12969
		private static readonly IntPtr NativeMethodInfoPtr_set_CanBeNone_Protected_set_Void_Boolean_0;

		// Token: 0x040032AA RID: 12970
		private static readonly IntPtr NativeMethodInfoPtr_get_OptionList_Public_get_List_1_String_0;

		// Token: 0x040032AB RID: 12971
		private static readonly IntPtr NativeMethodInfoPtr_set_OptionList_Protected_set_Void_List_1_String_0;

		// Token: 0x040032AC RID: 12972
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_List_1_String_Boolean_Boolean_0;

		// Token: 0x040032AD RID: 12973
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Option_0;

		// Token: 0x040032AE RID: 12974
		private static readonly IntPtr NativeMethodInfoPtr_GetDisplayString_Public_Virtual_String_0;
	}
}
