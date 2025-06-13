using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Trash
{
	// Token: 0x02000541 RID: 1345
	public class TrashContainerCollider : MonoBehaviour
	{
		// Token: 0x060076D1 RID: 30417 RVA: 0x00207A48 File Offset: 0x00205C48
		// Note: this type is marked as 'beforefieldinit'.
		static TrashContainerCollider()
		{
			Il2CppClassPointerStore<TrashContainerCollider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Trash", "TrashContainerCollider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashContainerCollider>.NativeClassPtr);
			TrashContainerCollider.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerCollider>.NativeClassPtr, "Container");
			TrashContainerCollider.NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerCollider>.NativeClassPtr, 100678332);
			TrashContainerCollider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerCollider>.NativeClassPtr, 100678333);
		}

		// Token: 0x060076D2 RID: 30418 RVA: 0x00207AB4 File Offset: 0x00205CB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231958, XrefRangeEnd = 231967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerCollider.NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060076D3 RID: 30419 RVA: 0x00207AF8 File Offset: 0x00205CF8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashContainerCollider() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashContainerCollider>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerCollider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060076D4 RID: 30420 RVA: 0x00038230 File Offset: 0x00036430
		public TrashContainerCollider(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023CB RID: 9163
		// (get) Token: 0x060076D5 RID: 30421 RVA: 0x00207B34 File Offset: 0x00205D34
		// (set) Token: 0x060076D6 RID: 30422 RVA: 0x00038239 File Offset: 0x00036439
		public unsafe TrashContainer Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerCollider.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerCollider.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005129 RID: 20777
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x0400512A RID: 20778
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0;

		// Token: 0x0400512B RID: 20779
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
