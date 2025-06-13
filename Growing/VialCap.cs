using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerTasks;
using UnityEngine;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x02000579 RID: 1401
	public class VialCap : Clickable
	{
		// Token: 0x06007A52 RID: 31314 RVA: 0x00213268 File Offset: 0x00211468
		// Note: this type is marked as 'beforefieldinit'.
		static VialCap()
		{
			Il2CppClassPointerStore<VialCap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "VialCap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VialCap>.NativeClassPtr);
			VialCap.NativeFieldInfoPtr__Removed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VialCap>.NativeClassPtr, "<Removed>k__BackingField");
			VialCap.NativeFieldInfoPtr_Collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VialCap>.NativeClassPtr, "Collider");
			VialCap.NativeFieldInfoPtr_RigidBody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VialCap>.NativeClassPtr, "RigidBody");
			VialCap.NativeMethodInfoPtr_get_Removed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VialCap>.NativeClassPtr, 100678755);
			VialCap.NativeMethodInfoPtr_set_Removed_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VialCap>.NativeClassPtr, 100678756);
			VialCap.NativeMethodInfoPtr_StartClick_Public_Virtual_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VialCap>.NativeClassPtr, 100678757);
			VialCap.NativeMethodInfoPtr_Pop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VialCap>.NativeClassPtr, 100678758);
			VialCap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VialCap>.NativeClassPtr, 100678759);
		}

		// Token: 0x170024C9 RID: 9417
		// (get) Token: 0x06007A53 RID: 31315 RVA: 0x00213338 File Offset: 0x00211538
		// (set) Token: 0x06007A54 RID: 31316 RVA: 0x00213374 File Offset: 0x00211574
		public unsafe bool Removed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VialCap.NativeMethodInfoPtr_get_Removed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VialCap.NativeMethodInfoPtr_set_Removed_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06007A55 RID: 31317 RVA: 0x002133B4 File Offset: 0x002115B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236090, XrefRangeEnd = 236092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartClick(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VialCap.NativeMethodInfoPtr_StartClick_Public_Virtual_Void_RaycastHit_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007A56 RID: 31318 RVA: 0x00213400 File Offset: 0x00211600
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 236118, RefRangeEnd = 236119, XrefRangeStart = 236092, XrefRangeEnd = 236118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Pop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VialCap.NativeMethodInfoPtr_Pop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007A57 RID: 31319 RVA: 0x00213434 File Offset: 0x00211634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236119, XrefRangeEnd = 236120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VialCap() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VialCap>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VialCap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007A58 RID: 31320 RVA: 0x00039C31 File Offset: 0x00037E31
		public VialCap(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024C6 RID: 9414
		// (get) Token: 0x06007A59 RID: 31321 RVA: 0x00213470 File Offset: 0x00211670
		// (set) Token: 0x06007A5A RID: 31322 RVA: 0x00039C3A File Offset: 0x00037E3A
		public unsafe bool _Removed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VialCap.NativeFieldInfoPtr__Removed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VialCap.NativeFieldInfoPtr__Removed_k__BackingField)) = value;
			}
		}

		// Token: 0x170024C7 RID: 9415
		// (get) Token: 0x06007A5B RID: 31323 RVA: 0x00213498 File Offset: 0x00211698
		// (set) Token: 0x06007A5C RID: 31324 RVA: 0x00039C55 File Offset: 0x00037E55
		public unsafe Collider Collider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VialCap.NativeFieldInfoPtr_Collider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VialCap.NativeFieldInfoPtr_Collider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024C8 RID: 9416
		// (get) Token: 0x06007A5D RID: 31325 RVA: 0x002134C8 File Offset: 0x002116C8
		// (set) Token: 0x06007A5E RID: 31326 RVA: 0x00039C74 File Offset: 0x00037E74
		public unsafe Rigidbody RigidBody
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VialCap.NativeFieldInfoPtr_RigidBody);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VialCap.NativeFieldInfoPtr_RigidBody), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005361 RID: 21345
		private static readonly IntPtr NativeFieldInfoPtr__Removed_k__BackingField;

		// Token: 0x04005362 RID: 21346
		private static readonly IntPtr NativeFieldInfoPtr_Collider;

		// Token: 0x04005363 RID: 21347
		private static readonly IntPtr NativeFieldInfoPtr_RigidBody;

		// Token: 0x04005364 RID: 21348
		private static readonly IntPtr NativeMethodInfoPtr_get_Removed_Public_get_Boolean_0;

		// Token: 0x04005365 RID: 21349
		private static readonly IntPtr NativeMethodInfoPtr_set_Removed_Protected_set_Void_Boolean_0;

		// Token: 0x04005366 RID: 21350
		private static readonly IntPtr NativeMethodInfoPtr_StartClick_Public_Virtual_Void_RaycastHit_0;

		// Token: 0x04005367 RID: 21351
		private static readonly IntPtr NativeMethodInfoPtr_Pop_Private_Void_0;

		// Token: 0x04005368 RID: 21352
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
