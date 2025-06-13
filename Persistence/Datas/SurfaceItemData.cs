using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002BE RID: 702
	[System.Serializable]
	public class SurfaceItemData : BuildableItemData
	{
		// Token: 0x06003249 RID: 12873 RVA: 0x00113CD8 File Offset: 0x00111ED8
		// Note: this type is marked as 'beforefieldinit'.
		static SurfaceItemData()
		{
			Il2CppClassPointerStore<SurfaceItemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "SurfaceItemData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SurfaceItemData>.NativeClassPtr);
			SurfaceItemData.NativeFieldInfoPtr_ParentSurfaceGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceItemData>.NativeClassPtr, "ParentSurfaceGUID");
			SurfaceItemData.NativeFieldInfoPtr_RelativePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceItemData>.NativeClassPtr, "RelativePosition");
			SurfaceItemData.NativeFieldInfoPtr_RelativeRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceItemData>.NativeClassPtr, "RelativeRotation");
			SurfaceItemData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_String_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItemData>.NativeClassPtr, 100669068);
		}

		// Token: 0x0600324A RID: 12874 RVA: 0x00113D58 File Offset: 0x00111F58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136998, RefRangeEnd = 136999, XrefRangeStart = 136993, XrefRangeEnd = 136998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SurfaceItemData(Il2CppSystem.Guid guid, ItemInstance item, int loadOrder, string parentSurfaceGUID, Vector3 pos, Quaternion rot) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SurfaceItemData>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref loadOrder;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentSurfaceGUID);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref pos;
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rot;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItemData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_String_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600324B RID: 12875 RVA: 0x0001A916 File Offset: 0x00018B16
		public SurfaceItemData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700103E RID: 4158
		// (get) Token: 0x0600324C RID: 12876 RVA: 0x00113DF0 File Offset: 0x00111FF0
		// (set) Token: 0x0600324D RID: 12877 RVA: 0x0001A91F File Offset: 0x00018B1F
		public unsafe string ParentSurfaceGUID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItemData.NativeFieldInfoPtr_ParentSurfaceGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItemData.NativeFieldInfoPtr_ParentSurfaceGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700103F RID: 4159
		// (get) Token: 0x0600324E RID: 12878 RVA: 0x00113E18 File Offset: 0x00112018
		// (set) Token: 0x0600324F RID: 12879 RVA: 0x0001A93E File Offset: 0x00018B3E
		public unsafe Vector3 RelativePosition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItemData.NativeFieldInfoPtr_RelativePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItemData.NativeFieldInfoPtr_RelativePosition)) = value;
			}
		}

		// Token: 0x17001040 RID: 4160
		// (get) Token: 0x06003250 RID: 12880 RVA: 0x00113E40 File Offset: 0x00112040
		// (set) Token: 0x06003251 RID: 12881 RVA: 0x0001A959 File Offset: 0x00018B59
		public unsafe Quaternion RelativeRotation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItemData.NativeFieldInfoPtr_RelativeRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItemData.NativeFieldInfoPtr_RelativeRotation)) = value;
			}
		}

		// Token: 0x040020CF RID: 8399
		private static readonly System.IntPtr NativeFieldInfoPtr_ParentSurfaceGUID;

		// Token: 0x040020D0 RID: 8400
		private static readonly System.IntPtr NativeFieldInfoPtr_RelativePosition;

		// Token: 0x040020D1 RID: 8401
		private static readonly System.IntPtr NativeFieldInfoPtr_RelativeRotation;

		// Token: 0x040020D2 RID: 8402
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_String_Vector3_Quaternion_0;
	}
}
