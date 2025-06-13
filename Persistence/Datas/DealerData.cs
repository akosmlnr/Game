using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002A9 RID: 681
	public class DealerData : NPCData
	{
		// Token: 0x06003176 RID: 12662 RVA: 0x00111574 File Offset: 0x0010F774
		// Note: this type is marked as 'beforefieldinit'.
		static DealerData()
		{
			Il2CppClassPointerStore<DealerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "DealerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealerData>.NativeClassPtr);
			DealerData.NativeFieldInfoPtr_Recruited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerData>.NativeClassPtr, "Recruited");
			DealerData.NativeFieldInfoPtr_AssignedCustomerIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerData>.NativeClassPtr, "AssignedCustomerIDs");
			DealerData.NativeFieldInfoPtr_ActiveContractGUIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerData>.NativeClassPtr, "ActiveContractGUIDs");
			DealerData.NativeFieldInfoPtr_Cash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerData>.NativeClassPtr, "Cash");
			DealerData.NativeFieldInfoPtr_OverflowItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerData>.NativeClassPtr, "OverflowItems");
			DealerData.NativeFieldInfoPtr_HasBeenRecommended = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerData>.NativeClassPtr, "HasBeenRecommended");
			DealerData.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Il2CppStringArray_Il2CppStringArray_Single_ItemSet_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerData>.NativeClassPtr, 100669047);
		}

		// Token: 0x06003177 RID: 12663 RVA: 0x00111630 File Offset: 0x0010F830
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136864, RefRangeEnd = 136865, XrefRangeStart = 136859, XrefRangeEnd = 136864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DealerData(string id, bool recruited, Il2CppStringArray assignedCustomerIDs, Il2CppStringArray activeContractGUIDs, float cash, ItemSet overflowItems, bool hasBeenRecommended) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealerData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recruited;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assignedCustomerIDs);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(activeContractGUIDs);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cash;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(overflowItems);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasBeenRecommended;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerData.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Il2CppStringArray_Il2CppStringArray_Single_ItemSet_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003178 RID: 12664 RVA: 0x00019FDF File Offset: 0x000181DF
		public DealerData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FF4 RID: 4084
		// (get) Token: 0x06003179 RID: 12665 RVA: 0x001116E0 File Offset: 0x0010F8E0
		// (set) Token: 0x0600317A RID: 12666 RVA: 0x00019FE8 File Offset: 0x000181E8
		public unsafe bool Recruited
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerData.NativeFieldInfoPtr_Recruited);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerData.NativeFieldInfoPtr_Recruited)) = value;
			}
		}

		// Token: 0x17000FF5 RID: 4085
		// (get) Token: 0x0600317B RID: 12667 RVA: 0x00111708 File Offset: 0x0010F908
		// (set) Token: 0x0600317C RID: 12668 RVA: 0x0001A003 File Offset: 0x00018203
		public unsafe Il2CppStringArray AssignedCustomerIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerData.NativeFieldInfoPtr_AssignedCustomerIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerData.NativeFieldInfoPtr_AssignedCustomerIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FF6 RID: 4086
		// (get) Token: 0x0600317D RID: 12669 RVA: 0x00111738 File Offset: 0x0010F938
		// (set) Token: 0x0600317E RID: 12670 RVA: 0x0001A022 File Offset: 0x00018222
		public unsafe Il2CppStringArray ActiveContractGUIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerData.NativeFieldInfoPtr_ActiveContractGUIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerData.NativeFieldInfoPtr_ActiveContractGUIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FF7 RID: 4087
		// (get) Token: 0x0600317F RID: 12671 RVA: 0x00111768 File Offset: 0x0010F968
		// (set) Token: 0x06003180 RID: 12672 RVA: 0x0001A041 File Offset: 0x00018241
		public unsafe float Cash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerData.NativeFieldInfoPtr_Cash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerData.NativeFieldInfoPtr_Cash)) = value;
			}
		}

		// Token: 0x17000FF8 RID: 4088
		// (get) Token: 0x06003181 RID: 12673 RVA: 0x00111790 File Offset: 0x0010F990
		// (set) Token: 0x06003182 RID: 12674 RVA: 0x0001A05C File Offset: 0x0001825C
		public unsafe ItemSet OverflowItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerData.NativeFieldInfoPtr_OverflowItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerData.NativeFieldInfoPtr_OverflowItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FF9 RID: 4089
		// (get) Token: 0x06003183 RID: 12675 RVA: 0x001117C0 File Offset: 0x0010F9C0
		// (set) Token: 0x06003184 RID: 12676 RVA: 0x0001A07B File Offset: 0x0001827B
		public unsafe bool HasBeenRecommended
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerData.NativeFieldInfoPtr_HasBeenRecommended);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerData.NativeFieldInfoPtr_HasBeenRecommended)) = value;
			}
		}

		// Token: 0x04002070 RID: 8304
		private static readonly IntPtr NativeFieldInfoPtr_Recruited;

		// Token: 0x04002071 RID: 8305
		private static readonly IntPtr NativeFieldInfoPtr_AssignedCustomerIDs;

		// Token: 0x04002072 RID: 8306
		private static readonly IntPtr NativeFieldInfoPtr_ActiveContractGUIDs;

		// Token: 0x04002073 RID: 8307
		private static readonly IntPtr NativeFieldInfoPtr_Cash;

		// Token: 0x04002074 RID: 8308
		private static readonly IntPtr NativeFieldInfoPtr_OverflowItems;

		// Token: 0x04002075 RID: 8309
		private static readonly IntPtr NativeFieldInfoPtr_HasBeenRecommended;

		// Token: 0x04002076 RID: 8310
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Il2CppStringArray_Il2CppStringArray_Single_ItemSet_Boolean_0;
	}
}
