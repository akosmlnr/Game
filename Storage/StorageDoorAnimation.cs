using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using UnityEngine;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x020005A5 RID: 1445
	public class StorageDoorAnimation : MonoBehaviour
	{
		// Token: 0x06007E4B RID: 32331 RVA: 0x00221420 File Offset: 0x0021F620
		// Note: this type is marked as 'beforefieldinit'.
		static StorageDoorAnimation()
		{
			Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "StorageDoorAnimation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr);
			StorageDoorAnimation.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, "<IsOpen>k__BackingField");
			StorageDoorAnimation.NativeFieldInfoPtr_overriddeIsOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, "overriddeIsOpen");
			StorageDoorAnimation.NativeFieldInfoPtr_overrideState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, "overrideState");
			StorageDoorAnimation.NativeFieldInfoPtr_ItemContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, "ItemContainer");
			StorageDoorAnimation.NativeFieldInfoPtr_Anims = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, "Anims");
			StorageDoorAnimation.NativeFieldInfoPtr_OpenAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, "OpenAnim");
			StorageDoorAnimation.NativeFieldInfoPtr_CloseAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, "CloseAnim");
			StorageDoorAnimation.NativeFieldInfoPtr_OpenSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, "OpenSound");
			StorageDoorAnimation.NativeFieldInfoPtr_CloseSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, "CloseSound");
			StorageDoorAnimation.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, 100679233);
			StorageDoorAnimation.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, 100679234);
			StorageDoorAnimation.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, 100679235);
			StorageDoorAnimation.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, 100679236);
			StorageDoorAnimation.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, 100679237);
			StorageDoorAnimation.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, 100679238);
			StorageDoorAnimation.NativeMethodInfoPtr_DisableItems_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, 100679239);
			StorageDoorAnimation.NativeMethodInfoPtr_OverrideState_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, 100679240);
			StorageDoorAnimation.NativeMethodInfoPtr_ResetOverride_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, 100679241);
			StorageDoorAnimation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, 100679242);
		}

		// Token: 0x170025FE RID: 9726
		// (get) Token: 0x06007E4C RID: 32332 RVA: 0x002215CC File Offset: 0x0021F7CC
		// (set) Token: 0x06007E4D RID: 32333 RVA: 0x00221608 File Offset: 0x0021F808
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37513, RefRangeEnd = 37514, XrefRangeStart = 37513, XrefRangeEnd = 37514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(StorageDoorAnimation.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 37514, RefRangeEnd = 37516, XrefRangeStart = 37514, XrefRangeEnd = 37516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageDoorAnimation.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06007E4E RID: 32334 RVA: 0x00221648 File Offset: 0x0021F848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241040, XrefRangeEnd = 241046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageDoorAnimation.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007E4F RID: 32335 RVA: 0x0022167C File Offset: 0x0021F87C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241046, XrefRangeEnd = 241047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageDoorAnimation.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007E50 RID: 32336 RVA: 0x002216B0 File Offset: 0x0021F8B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241047, XrefRangeEnd = 241048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageDoorAnimation.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007E51 RID: 32337 RVA: 0x002216E4 File Offset: 0x0021F8E4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 241068, RefRangeEnd = 241076, XrefRangeStart = 241048, XrefRangeEnd = 241068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageDoorAnimation.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007E52 RID: 32338 RVA: 0x00221724 File Offset: 0x0021F924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241076, XrefRangeEnd = 241082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageDoorAnimation.NativeMethodInfoPtr_DisableItems_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007E53 RID: 32339 RVA: 0x00221758 File Offset: 0x0021F958
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 241083, RefRangeEnd = 241084, XrefRangeStart = 241082, XrefRangeEnd = 241083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideState(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageDoorAnimation.NativeMethodInfoPtr_OverrideState_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007E54 RID: 32340 RVA: 0x00221798 File Offset: 0x0021F998
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 221210, RefRangeEnd = 221212, XrefRangeStart = 221210, XrefRangeEnd = 221212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetOverride()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageDoorAnimation.NativeMethodInfoPtr_ResetOverride_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007E55 RID: 32341 RVA: 0x002217CC File Offset: 0x0021F9CC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorageDoorAnimation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageDoorAnimation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007E56 RID: 32342 RVA: 0x0003BA57 File Offset: 0x00039C57
		public StorageDoorAnimation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170025F5 RID: 9717
		// (get) Token: 0x06007E57 RID: 32343 RVA: 0x00221808 File Offset: 0x0021FA08
		// (set) Token: 0x06007E58 RID: 32344 RVA: 0x0003BA60 File Offset: 0x00039C60
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x170025F6 RID: 9718
		// (get) Token: 0x06007E59 RID: 32345 RVA: 0x00221830 File Offset: 0x0021FA30
		// (set) Token: 0x06007E5A RID: 32346 RVA: 0x0003BA7B File Offset: 0x00039C7B
		public unsafe bool overriddeIsOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_overriddeIsOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_overriddeIsOpen)) = value;
			}
		}

		// Token: 0x170025F7 RID: 9719
		// (get) Token: 0x06007E5B RID: 32347 RVA: 0x00221858 File Offset: 0x0021FA58
		// (set) Token: 0x06007E5C RID: 32348 RVA: 0x0003BA96 File Offset: 0x00039C96
		public unsafe bool overrideState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_overrideState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_overrideState)) = value;
			}
		}

		// Token: 0x170025F8 RID: 9720
		// (get) Token: 0x06007E5D RID: 32349 RVA: 0x00221880 File Offset: 0x0021FA80
		// (set) Token: 0x06007E5E RID: 32350 RVA: 0x0003BAB1 File Offset: 0x00039CB1
		public unsafe Transform ItemContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_ItemContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_ItemContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025F9 RID: 9721
		// (get) Token: 0x06007E5F RID: 32351 RVA: 0x002218B0 File Offset: 0x0021FAB0
		// (set) Token: 0x06007E60 RID: 32352 RVA: 0x0003BAD0 File Offset: 0x00039CD0
		public unsafe Il2CppReferenceArray<Animation> Anims
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_Anims);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Animation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_Anims), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025FA RID: 9722
		// (get) Token: 0x06007E61 RID: 32353 RVA: 0x002218E0 File Offset: 0x0021FAE0
		// (set) Token: 0x06007E62 RID: 32354 RVA: 0x0003BAEF File Offset: 0x00039CEF
		public unsafe AnimationClip OpenAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_OpenAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_OpenAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025FB RID: 9723
		// (get) Token: 0x06007E63 RID: 32355 RVA: 0x00221910 File Offset: 0x0021FB10
		// (set) Token: 0x06007E64 RID: 32356 RVA: 0x0003BB0E File Offset: 0x00039D0E
		public unsafe AnimationClip CloseAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_CloseAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_CloseAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025FC RID: 9724
		// (get) Token: 0x06007E65 RID: 32357 RVA: 0x00221940 File Offset: 0x0021FB40
		// (set) Token: 0x06007E66 RID: 32358 RVA: 0x0003BB2D File Offset: 0x00039D2D
		public unsafe AudioSourceController OpenSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_OpenSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_OpenSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025FD RID: 9725
		// (get) Token: 0x06007E67 RID: 32359 RVA: 0x00221970 File Offset: 0x0021FB70
		// (set) Token: 0x06007E68 RID: 32360 RVA: 0x0003BB4C File Offset: 0x00039D4C
		public unsafe AudioSourceController CloseSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_CloseSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_CloseSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005609 RID: 22025
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x0400560A RID: 22026
		private static readonly IntPtr NativeFieldInfoPtr_overriddeIsOpen;

		// Token: 0x0400560B RID: 22027
		private static readonly IntPtr NativeFieldInfoPtr_overrideState;

		// Token: 0x0400560C RID: 22028
		private static readonly IntPtr NativeFieldInfoPtr_ItemContainer;

		// Token: 0x0400560D RID: 22029
		private static readonly IntPtr NativeFieldInfoPtr_Anims;

		// Token: 0x0400560E RID: 22030
		private static readonly IntPtr NativeFieldInfoPtr_OpenAnim;

		// Token: 0x0400560F RID: 22031
		private static readonly IntPtr NativeFieldInfoPtr_CloseAnim;

		// Token: 0x04005610 RID: 22032
		private static readonly IntPtr NativeFieldInfoPtr_OpenSound;

		// Token: 0x04005611 RID: 22033
		private static readonly IntPtr NativeFieldInfoPtr_CloseSound;

		// Token: 0x04005612 RID: 22034
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04005613 RID: 22035
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04005614 RID: 22036
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04005615 RID: 22037
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04005616 RID: 22038
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04005617 RID: 22039
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0;

		// Token: 0x04005618 RID: 22040
		private static readonly IntPtr NativeMethodInfoPtr_DisableItems_Private_Void_0;

		// Token: 0x04005619 RID: 22041
		private static readonly IntPtr NativeMethodInfoPtr_OverrideState_Public_Void_Boolean_0;

		// Token: 0x0400561A RID: 22042
		private static readonly IntPtr NativeMethodInfoPtr_ResetOverride_Public_Void_0;

		// Token: 0x0400561B RID: 22043
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
