using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000293 RID: 659
	[System.Serializable]
	public class ItemFieldData : Il2CppSystem.Object
	{
		// Token: 0x060030DF RID: 12511 RVA: 0x0010FB20 File Offset: 0x0010DD20
		// Note: this type is marked as 'beforefieldinit'.
		static ItemFieldData()
		{
			Il2CppClassPointerStore<ItemFieldData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ItemFieldData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemFieldData>.NativeClassPtr);
			ItemFieldData.NativeFieldInfoPtr_ItemID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFieldData>.NativeClassPtr, "ItemID");
			ItemFieldData.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFieldData>.NativeClassPtr, 100669024);
		}

		// Token: 0x060030E0 RID: 12512 RVA: 0x0010FB78 File Offset: 0x0010DD78
		[CallerCount(203)]
		[CachedScanResults(RefRangeStart = 19232, RefRangeEnd = 19435, XrefRangeStart = 19232, XrefRangeEnd = 19435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemFieldData(string itemID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemFieldData>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(itemID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFieldData.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060030E1 RID: 12513 RVA: 0x00019A37 File Offset: 0x00017C37
		public ItemFieldData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FCA RID: 4042
		// (get) Token: 0x060030E2 RID: 12514 RVA: 0x0010FBC4 File Offset: 0x0010DDC4
		// (set) Token: 0x060030E3 RID: 12515 RVA: 0x00019A40 File Offset: 0x00017C40
		public unsafe string ItemID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldData.NativeFieldInfoPtr_ItemID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldData.NativeFieldInfoPtr_ItemID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400202F RID: 8239
		private static readonly System.IntPtr NativeFieldInfoPtr_ItemID;

		// Token: 0x04002030 RID: 8240
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
