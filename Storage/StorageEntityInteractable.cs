using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Interaction;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x02000598 RID: 1432
	public class StorageEntityInteractable : InteractableObject
	{
		// Token: 0x06007D3D RID: 32061 RVA: 0x0021D93C File Offset: 0x0021BB3C
		// Note: this type is marked as 'beforefieldinit'.
		static StorageEntityInteractable()
		{
			Il2CppClassPointerStore<StorageEntityInteractable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "StorageEntityInteractable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageEntityInteractable>.NativeClassPtr);
			StorageEntityInteractable.NativeFieldInfoPtr_StorageEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageEntityInteractable>.NativeClassPtr, "StorageEntity");
			StorageEntityInteractable.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageEntityInteractable>.NativeClassPtr, 100679101);
			StorageEntityInteractable.NativeMethodInfoPtr_Hovered_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageEntityInteractable>.NativeClassPtr, 100679102);
			StorageEntityInteractable.NativeMethodInfoPtr_StartInteract_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageEntityInteractable>.NativeClassPtr, 100679103);
			StorageEntityInteractable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageEntityInteractable>.NativeClassPtr, 100679104);
		}

		// Token: 0x06007D3E RID: 32062 RVA: 0x0021D9D0 File Offset: 0x0021BBD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239746, XrefRangeEnd = 239750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageEntityInteractable.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007D3F RID: 32063 RVA: 0x0021DA04 File Offset: 0x0021BC04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239750, XrefRangeEnd = 239751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageEntityInteractable.NativeMethodInfoPtr_Hovered_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007D40 RID: 32064 RVA: 0x0021DA40 File Offset: 0x0021BC40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239751, XrefRangeEnd = 239768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartInteract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageEntityInteractable.NativeMethodInfoPtr_StartInteract_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007D41 RID: 32065 RVA: 0x0021DA7C File Offset: 0x0021BC7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239768, XrefRangeEnd = 239769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorageEntityInteractable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageEntityInteractable>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageEntityInteractable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007D42 RID: 32066 RVA: 0x0003B2E3 File Offset: 0x000394E3
		public StorageEntityInteractable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700259D RID: 9629
		// (get) Token: 0x06007D43 RID: 32067 RVA: 0x0021DAB8 File Offset: 0x0021BCB8
		// (set) Token: 0x06007D44 RID: 32068 RVA: 0x0003B2EC File Offset: 0x000394EC
		public unsafe StorageEntity StorageEntity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageEntityInteractable.NativeFieldInfoPtr_StorageEntity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageEntityInteractable.NativeFieldInfoPtr_StorageEntity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005552 RID: 21842
		private static readonly IntPtr NativeFieldInfoPtr_StorageEntity;

		// Token: 0x04005553 RID: 21843
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005554 RID: 21844
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Virtual_Void_0;

		// Token: 0x04005555 RID: 21845
		private static readonly IntPtr NativeMethodInfoPtr_StartInteract_Public_Virtual_Void_0;

		// Token: 0x04005556 RID: 21846
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
