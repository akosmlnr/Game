using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x0200063F RID: 1599
	public class ACAssetPathReplicator<T> : ACReplicator where T : UnityEngine.Object
	{
		// Token: 0x06008C7E RID: 35966 RVA: 0x0024FAA4 File Offset: 0x0024DCA4
		// Note: this type is marked as 'beforefieldinit'.
		static ACAssetPathReplicator()
		{
			Il2CppClassPointerStore<ACAssetPathReplicator<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "ACAssetPathReplicator`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACAssetPathReplicator<T>>.NativeClassPtr);
			ACAssetPathReplicator<T>.NativeFieldInfoPtr_selection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACAssetPathReplicator<T>>.NativeClassPtr, "selection");
			ACAssetPathReplicator<T>.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACAssetPathReplicator<T>>.NativeClassPtr, 100680864);
			ACAssetPathReplicator<T>.NativeMethodInfoPtr_AvatarSettingsChanged_Protected_Virtual_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACAssetPathReplicator<T>>.NativeClassPtr, 100680865);
			ACAssetPathReplicator<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACAssetPathReplicator<T>>.NativeClassPtr, 100680866);
		}

		// Token: 0x06008C7F RID: 35967 RVA: 0x0024FB60 File Offset: 0x0024DD60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258126, XrefRangeEnd = 258129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACAssetPathReplicator<T>.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C80 RID: 35968 RVA: 0x0024FB9C File Offset: 0x0024DD9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258129, XrefRangeEnd = 258134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AvatarSettingsChanged(AvatarSettings newSettings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newSettings);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACAssetPathReplicator<T>.NativeMethodInfoPtr_AvatarSettingsChanged_Protected_Virtual_Void_AvatarSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C81 RID: 35969 RVA: 0x0024FBEC File Offset: 0x0024DDEC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 258135, RefRangeEnd = 258138, XrefRangeStart = 258134, XrefRangeEnd = 258135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ACAssetPathReplicator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACAssetPathReplicator<T>>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACAssetPathReplicator<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C82 RID: 35970 RVA: 0x00042E8D File Offset: 0x0004108D
		public ACAssetPathReplicator(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A9C RID: 10908
		// (get) Token: 0x06008C83 RID: 35971 RVA: 0x0024FC28 File Offset: 0x0024DE28
		// (set) Token: 0x06008C84 RID: 35972 RVA: 0x00042E96 File Offset: 0x00041096
		public unsafe ACSelection<T> selection
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ACAssetPathReplicator<T>.NativeFieldInfoPtr_selection);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ACSelection<T>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ACAssetPathReplicator<T>.NativeFieldInfoPtr_selection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005F62 RID: 24418
		private static readonly System.IntPtr NativeFieldInfoPtr_selection;

		// Token: 0x04005F63 RID: 24419
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04005F64 RID: 24420
		private static readonly System.IntPtr NativeMethodInfoPtr_AvatarSettingsChanged_Protected_Virtual_Void_AvatarSettings_0;

		// Token: 0x04005F65 RID: 24421
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
