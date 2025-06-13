using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002E0 RID: 736
	[System.Serializable]
	public class WorldStorageEntityData : SaveData
	{
		// Token: 0x06003381 RID: 13185 RVA: 0x00117264 File Offset: 0x00115464
		// Note: this type is marked as 'beforefieldinit'.
		static WorldStorageEntityData()
		{
			Il2CppClassPointerStore<WorldStorageEntityData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "WorldStorageEntityData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldStorageEntityData>.NativeClassPtr);
			WorldStorageEntityData.NativeFieldInfoPtr_GUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldStorageEntityData>.NativeClassPtr, "GUID");
			WorldStorageEntityData.NativeFieldInfoPtr_Contents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldStorageEntityData>.NativeClassPtr, "Contents");
			WorldStorageEntityData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntityData>.NativeClassPtr, 100669110);
		}

		// Token: 0x06003382 RID: 13186 RVA: 0x001172D0 File Offset: 0x001154D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137293, RefRangeEnd = 137294, XrefRangeStart = 137289, XrefRangeEnd = 137293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorldStorageEntityData(Il2CppSystem.Guid guid, ItemSet contents) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldStorageEntityData>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contents);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldStorageEntityData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003383 RID: 13187 RVA: 0x0001B61E File Offset: 0x0001981E
		public WorldStorageEntityData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170010A4 RID: 4260
		// (get) Token: 0x06003384 RID: 13188 RVA: 0x0011732C File Offset: 0x0011552C
		// (set) Token: 0x06003385 RID: 13189 RVA: 0x0001B627 File Offset: 0x00019827
		public unsafe string GUID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntityData.NativeFieldInfoPtr_GUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntityData.NativeFieldInfoPtr_GUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010A5 RID: 4261
		// (get) Token: 0x06003386 RID: 13190 RVA: 0x00117354 File Offset: 0x00115554
		// (set) Token: 0x06003387 RID: 13191 RVA: 0x0001B646 File Offset: 0x00019846
		public unsafe ItemSet Contents
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntityData.NativeFieldInfoPtr_Contents);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntityData.NativeFieldInfoPtr_Contents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400215E RID: 8542
		private static readonly System.IntPtr NativeFieldInfoPtr_GUID;

		// Token: 0x0400215F RID: 8543
		private static readonly System.IntPtr NativeFieldInfoPtr_Contents;

		// Token: 0x04002160 RID: 8544
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemSet_0;
	}
}
