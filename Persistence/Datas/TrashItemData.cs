using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002DA RID: 730
	[System.Serializable]
	public class TrashItemData : Il2CppSystem.Object
	{
		// Token: 0x0600334C RID: 13132 RVA: 0x00116A00 File Offset: 0x00114C00
		// Note: this type is marked as 'beforefieldinit'.
		static TrashItemData()
		{
			Il2CppClassPointerStore<TrashItemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "TrashItemData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashItemData>.NativeClassPtr);
			TrashItemData.NativeFieldInfoPtr_DataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItemData>.NativeClassPtr, "DataType");
			TrashItemData.NativeFieldInfoPtr_TrashID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItemData>.NativeClassPtr, "TrashID");
			TrashItemData.NativeFieldInfoPtr_GUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItemData>.NativeClassPtr, "GUID");
			TrashItemData.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItemData>.NativeClassPtr, "Position");
			TrashItemData.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItemData>.NativeClassPtr, "Rotation");
			TrashItemData.NativeFieldInfoPtr_Contents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItemData>.NativeClassPtr, "Contents");
			TrashItemData.NativeMethodInfoPtr__ctor_Public_Void_String_String_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItemData>.NativeClassPtr, 100669103);
		}

		// Token: 0x0600334D RID: 13133 RVA: 0x00116ABC File Offset: 0x00114CBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137269, RefRangeEnd = 137270, XrefRangeStart = 137259, XrefRangeEnd = 137269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashItemData(string trashID, string guid, Vector3 position, Quaternion rotation) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashItemData>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trashID);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref position;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rotation;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItemData.NativeMethodInfoPtr__ctor_Public_Void_String_String_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600334E RID: 13134 RVA: 0x0001B3E9 File Offset: 0x000195E9
		public TrashItemData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001093 RID: 4243
		// (get) Token: 0x0600334F RID: 13135 RVA: 0x00116B38 File Offset: 0x00114D38
		// (set) Token: 0x06003350 RID: 13136 RVA: 0x0001B3F2 File Offset: 0x000195F2
		public unsafe string DataType
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItemData.NativeFieldInfoPtr_DataType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItemData.NativeFieldInfoPtr_DataType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001094 RID: 4244
		// (get) Token: 0x06003351 RID: 13137 RVA: 0x00116B60 File Offset: 0x00114D60
		// (set) Token: 0x06003352 RID: 13138 RVA: 0x0001B411 File Offset: 0x00019611
		public unsafe string TrashID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItemData.NativeFieldInfoPtr_TrashID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItemData.NativeFieldInfoPtr_TrashID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001095 RID: 4245
		// (get) Token: 0x06003353 RID: 13139 RVA: 0x00116B88 File Offset: 0x00114D88
		// (set) Token: 0x06003354 RID: 13140 RVA: 0x0001B430 File Offset: 0x00019630
		public unsafe string GUID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItemData.NativeFieldInfoPtr_GUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItemData.NativeFieldInfoPtr_GUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001096 RID: 4246
		// (get) Token: 0x06003355 RID: 13141 RVA: 0x00116BB0 File Offset: 0x00114DB0
		// (set) Token: 0x06003356 RID: 13142 RVA: 0x0001B44F File Offset: 0x0001964F
		public unsafe Vector3 Position
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItemData.NativeFieldInfoPtr_Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItemData.NativeFieldInfoPtr_Position)) = value;
			}
		}

		// Token: 0x17001097 RID: 4247
		// (get) Token: 0x06003357 RID: 13143 RVA: 0x00116BD8 File Offset: 0x00114DD8
		// (set) Token: 0x06003358 RID: 13144 RVA: 0x0001B46A File Offset: 0x0001966A
		public unsafe Quaternion Rotation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItemData.NativeFieldInfoPtr_Rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItemData.NativeFieldInfoPtr_Rotation)) = value;
			}
		}

		// Token: 0x17001098 RID: 4248
		// (get) Token: 0x06003359 RID: 13145 RVA: 0x00116C00 File Offset: 0x00114E00
		// (set) Token: 0x0600335A RID: 13146 RVA: 0x0001B485 File Offset: 0x00019685
		public unsafe TrashContentData Contents
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItemData.NativeFieldInfoPtr_Contents);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashContentData>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItemData.NativeFieldInfoPtr_Contents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002146 RID: 8518
		private static readonly System.IntPtr NativeFieldInfoPtr_DataType;

		// Token: 0x04002147 RID: 8519
		private static readonly System.IntPtr NativeFieldInfoPtr_TrashID;

		// Token: 0x04002148 RID: 8520
		private static readonly System.IntPtr NativeFieldInfoPtr_GUID;

		// Token: 0x04002149 RID: 8521
		private static readonly System.IntPtr NativeFieldInfoPtr_Position;

		// Token: 0x0400214A RID: 8522
		private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;

		// Token: 0x0400214B RID: 8523
		private static readonly System.IntPtr NativeFieldInfoPtr_Contents;

		// Token: 0x0400214C RID: 8524
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Vector3_Quaternion_0;
	}
}
