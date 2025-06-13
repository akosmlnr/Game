using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Property
{
	// Token: 0x02000533 RID: 1331
	public class PropertyDisposalArea : MonoBehaviour
	{
		// Token: 0x06007544 RID: 30020 RVA: 0x00201F60 File Offset: 0x00200160
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyDisposalArea()
		{
			Il2CppClassPointerStore<PropertyDisposalArea>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property", "PropertyDisposalArea");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyDisposalArea>.NativeClassPtr);
			PropertyDisposalArea.NativeFieldInfoPtr_StandPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDisposalArea>.NativeClassPtr, "StandPoint");
			PropertyDisposalArea.NativeFieldInfoPtr_TrashDropPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDisposalArea>.NativeClassPtr, "TrashDropPoint");
			PropertyDisposalArea.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDisposalArea>.NativeClassPtr, 100678114);
		}

		// Token: 0x06007545 RID: 30021 RVA: 0x00201FCC File Offset: 0x002001CC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyDisposalArea() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyDisposalArea>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyDisposalArea.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007546 RID: 30022 RVA: 0x0003787B File Offset: 0x00035A7B
		public PropertyDisposalArea(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700235E RID: 9054
		// (get) Token: 0x06007547 RID: 30023 RVA: 0x00202008 File Offset: 0x00200208
		// (set) Token: 0x06007548 RID: 30024 RVA: 0x00037884 File Offset: 0x00035A84
		public unsafe Transform StandPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDisposalArea.NativeFieldInfoPtr_StandPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDisposalArea.NativeFieldInfoPtr_StandPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700235F RID: 9055
		// (get) Token: 0x06007549 RID: 30025 RVA: 0x00202038 File Offset: 0x00200238
		// (set) Token: 0x0600754A RID: 30026 RVA: 0x000378A3 File Offset: 0x00035AA3
		public unsafe Transform TrashDropPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDisposalArea.NativeFieldInfoPtr_TrashDropPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDisposalArea.NativeFieldInfoPtr_TrashDropPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400500E RID: 20494
		private static readonly IntPtr NativeFieldInfoPtr_StandPoint;

		// Token: 0x0400500F RID: 20495
		private static readonly IntPtr NativeFieldInfoPtr_TrashDropPoint;

		// Token: 0x04005010 RID: 20496
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
