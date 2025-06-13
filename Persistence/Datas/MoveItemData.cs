using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002AB RID: 683
	[System.Serializable]
	public class MoveItemData : Il2CppSystem.Object
	{
		// Token: 0x0600319A RID: 12698 RVA: 0x00111B20 File Offset: 0x0010FD20
		// Note: this type is marked as 'beforefieldinit'.
		static MoveItemData()
		{
			Il2CppClassPointerStore<MoveItemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "MoveItemData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveItemData>.NativeClassPtr);
			MoveItemData.NativeFieldInfoPtr_TemplateItemJSON = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemData>.NativeClassPtr, "TemplateItemJSON");
			MoveItemData.NativeFieldInfoPtr_GrabbedItemQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemData>.NativeClassPtr, "GrabbedItemQuantity");
			MoveItemData.NativeFieldInfoPtr_SourceGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemData>.NativeClassPtr, "SourceGUID");
			MoveItemData.NativeFieldInfoPtr_DestinationGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemData>.NativeClassPtr, "DestinationGUID");
			MoveItemData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Guid_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemData>.NativeClassPtr, 100669049);
		}

		// Token: 0x0600319B RID: 12699 RVA: 0x00111BB4 File Offset: 0x0010FDB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136882, RefRangeEnd = 136883, XrefRangeStart = 136873, XrefRangeEnd = 136882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoveItemData(string templateItemJson, int grabbedItemQuantity, Il2CppSystem.Guid sourceGUID, Il2CppSystem.Guid destinationGUID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveItemData>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(templateItemJson);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref grabbedItemQuantity;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref sourceGUID;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref destinationGUID;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Guid_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600319C RID: 12700 RVA: 0x0001A1A2 File Offset: 0x000183A2
		public MoveItemData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001003 RID: 4099
		// (get) Token: 0x0600319D RID: 12701 RVA: 0x00111C2C File Offset: 0x0010FE2C
		// (set) Token: 0x0600319E RID: 12702 RVA: 0x0001A1AB File Offset: 0x000183AB
		public unsafe string TemplateItemJSON
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemData.NativeFieldInfoPtr_TemplateItemJSON);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemData.NativeFieldInfoPtr_TemplateItemJSON), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001004 RID: 4100
		// (get) Token: 0x0600319F RID: 12703 RVA: 0x00111C54 File Offset: 0x0010FE54
		// (set) Token: 0x060031A0 RID: 12704 RVA: 0x0001A1CA File Offset: 0x000183CA
		public unsafe int GrabbedItemQuantity
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemData.NativeFieldInfoPtr_GrabbedItemQuantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemData.NativeFieldInfoPtr_GrabbedItemQuantity)) = value;
			}
		}

		// Token: 0x17001005 RID: 4101
		// (get) Token: 0x060031A1 RID: 12705 RVA: 0x00111C7C File Offset: 0x0010FE7C
		// (set) Token: 0x060031A2 RID: 12706 RVA: 0x0001A1E5 File Offset: 0x000183E5
		public unsafe string SourceGUID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemData.NativeFieldInfoPtr_SourceGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemData.NativeFieldInfoPtr_SourceGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001006 RID: 4102
		// (get) Token: 0x060031A3 RID: 12707 RVA: 0x00111CA4 File Offset: 0x0010FEA4
		// (set) Token: 0x060031A4 RID: 12708 RVA: 0x0001A204 File Offset: 0x00018404
		public unsafe string DestinationGUID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemData.NativeFieldInfoPtr_DestinationGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemData.NativeFieldInfoPtr_DestinationGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002081 RID: 8321
		private static readonly System.IntPtr NativeFieldInfoPtr_TemplateItemJSON;

		// Token: 0x04002082 RID: 8322
		private static readonly System.IntPtr NativeFieldInfoPtr_GrabbedItemQuantity;

		// Token: 0x04002083 RID: 8323
		private static readonly System.IntPtr NativeFieldInfoPtr_SourceGUID;

		// Token: 0x04002084 RID: 8324
		private static readonly System.IntPtr NativeFieldInfoPtr_DestinationGUID;

		// Token: 0x04002085 RID: 8325
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Guid_Guid_0;
	}
}
