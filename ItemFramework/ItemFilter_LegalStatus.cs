using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005FD RID: 1533
	public class ItemFilter_LegalStatus : ItemFilter
	{
		// Token: 0x06008576 RID: 34166 RVA: 0x00239C1C File Offset: 0x00237E1C
		// Note: this type is marked as 'beforefieldinit'.
		static ItemFilter_LegalStatus()
		{
			Il2CppClassPointerStore<ItemFilter_LegalStatus>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemFilter_LegalStatus");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemFilter_LegalStatus>.NativeClassPtr);
			ItemFilter_LegalStatus.NativeFieldInfoPtr_RequiredLegalStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFilter_LegalStatus>.NativeClassPtr, "RequiredLegalStatus");
			ItemFilter_LegalStatus.NativeMethodInfoPtr__ctor_Public_Void_ELegalStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_LegalStatus>.NativeClassPtr, 100680087);
			ItemFilter_LegalStatus.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_LegalStatus>.NativeClassPtr, 100680088);
		}

		// Token: 0x06008577 RID: 34167 RVA: 0x00239C88 File Offset: 0x00237E88
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemFilter_LegalStatus(ELegalStatus requiredLegalStatus) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemFilter_LegalStatus>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref requiredLegalStatus;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFilter_LegalStatus.NativeMethodInfoPtr__ctor_Public_Void_ELegalStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008578 RID: 34168 RVA: 0x00239CD0 File Offset: 0x00237ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250902, XrefRangeEnd = 250903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DoesItemMatchFilter(ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemFilter_LegalStatus.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008579 RID: 34169 RVA: 0x0003F25E File Offset: 0x0003D45E
		public ItemFilter_LegalStatus(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700282B RID: 10283
		// (get) Token: 0x0600857A RID: 34170 RVA: 0x00239D28 File Offset: 0x00237F28
		// (set) Token: 0x0600857B RID: 34171 RVA: 0x0003F267 File Offset: 0x0003D467
		public unsafe ELegalStatus RequiredLegalStatus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFilter_LegalStatus.NativeFieldInfoPtr_RequiredLegalStatus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFilter_LegalStatus.NativeFieldInfoPtr_RequiredLegalStatus)) = value;
			}
		}

		// Token: 0x04005ADE RID: 23262
		private static readonly IntPtr NativeFieldInfoPtr_RequiredLegalStatus;

		// Token: 0x04005ADF RID: 23263
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ELegalStatus_0;

		// Token: 0x04005AE0 RID: 23264
		private static readonly IntPtr NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0;
	}
}
