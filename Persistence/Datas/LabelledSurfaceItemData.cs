using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002B5 RID: 693
	public class LabelledSurfaceItemData : SurfaceItemData
	{
		// Token: 0x060031FC RID: 12796 RVA: 0x00112D4C File Offset: 0x00110F4C
		// Note: this type is marked as 'beforefieldinit'.
		static LabelledSurfaceItemData()
		{
			Il2CppClassPointerStore<LabelledSurfaceItemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "LabelledSurfaceItemData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabelledSurfaceItemData>.NativeClassPtr);
			LabelledSurfaceItemData.NativeFieldInfoPtr_Message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabelledSurfaceItemData>.NativeClassPtr, "Message");
			LabelledSurfaceItemData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_String_Vector3_Quaternion_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelledSurfaceItemData>.NativeClassPtr, 100669059);
		}

		// Token: 0x060031FD RID: 12797 RVA: 0x00112DA4 File Offset: 0x00110FA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 136951, RefRangeEnd = 136953, XrefRangeStart = 136944, XrefRangeEnd = 136951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabelledSurfaceItemData(Il2CppSystem.Guid guid, ItemInstance item, int loadOrder, string parentSurfaceGUID, Vector3 pos, Quaternion rot, string message) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabelledSurfaceItemData>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)7) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref loadOrder;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentSurfaceGUID);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref pos;
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rot;
			ptr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelledSurfaceItemData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_String_Vector3_Quaternion_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060031FE RID: 12798 RVA: 0x0001A5DE File Offset: 0x000187DE
		public LabelledSurfaceItemData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001025 RID: 4133
		// (get) Token: 0x060031FF RID: 12799 RVA: 0x00112E50 File Offset: 0x00111050
		// (set) Token: 0x06003200 RID: 12800 RVA: 0x0001A5E7 File Offset: 0x000187E7
		public unsafe string Message
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LabelledSurfaceItemData.NativeFieldInfoPtr_Message);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LabelledSurfaceItemData.NativeFieldInfoPtr_Message), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040020AD RID: 8365
		private static readonly System.IntPtr NativeFieldInfoPtr_Message;

		// Token: 0x040020AE RID: 8366
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_String_Vector3_Quaternion_String_0;
	}
}
