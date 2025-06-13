using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200054D RID: 1357
	public class ActiveInRange : MonoBehaviour
	{
		// Token: 0x06007842 RID: 30786 RVA: 0x0020D4D0 File Offset: 0x0020B6D0
		// Note: this type is marked as 'beforefieldinit'.
		static ActiveInRange()
		{
			Il2CppClassPointerStore<ActiveInRange>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "ActiveInRange");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActiveInRange>.NativeClassPtr);
			ActiveInRange.NativeFieldInfoPtr_Distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveInRange>.NativeClassPtr, "Distance");
			ActiveInRange.NativeFieldInfoPtr_ScaleByLODBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveInRange>.NativeClassPtr, "ScaleByLODBias");
			ActiveInRange.NativeFieldInfoPtr_ObjectsToActivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveInRange>.NativeClassPtr, "ObjectsToActivate");
			ActiveInRange.NativeFieldInfoPtr_Reverse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveInRange>.NativeClassPtr, "Reverse");
			ActiveInRange.NativeFieldInfoPtr_isVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveInRange>.NativeClassPtr, "isVisible");
			ActiveInRange.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveInRange>.NativeClassPtr, 100678544);
			ActiveInRange.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveInRange>.NativeClassPtr, 100678545);
		}

		// Token: 0x06007843 RID: 30787 RVA: 0x0020D58C File Offset: 0x0020B78C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234448, XrefRangeEnd = 234470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveInRange.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007844 RID: 30788 RVA: 0x0020D5C0 File Offset: 0x0020B7C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234470, XrefRangeEnd = 234471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActiveInRange() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActiveInRange>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveInRange.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007845 RID: 30789 RVA: 0x00038BC1 File Offset: 0x00036DC1
		public ActiveInRange(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002437 RID: 9271
		// (get) Token: 0x06007846 RID: 30790 RVA: 0x0020D5FC File Offset: 0x0020B7FC
		// (set) Token: 0x06007847 RID: 30791 RVA: 0x00038BCA File Offset: 0x00036DCA
		public unsafe float Distance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveInRange.NativeFieldInfoPtr_Distance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveInRange.NativeFieldInfoPtr_Distance)) = value;
			}
		}

		// Token: 0x17002438 RID: 9272
		// (get) Token: 0x06007848 RID: 30792 RVA: 0x0020D624 File Offset: 0x0020B824
		// (set) Token: 0x06007849 RID: 30793 RVA: 0x00038BE5 File Offset: 0x00036DE5
		public unsafe bool ScaleByLODBias
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveInRange.NativeFieldInfoPtr_ScaleByLODBias);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveInRange.NativeFieldInfoPtr_ScaleByLODBias)) = value;
			}
		}

		// Token: 0x17002439 RID: 9273
		// (get) Token: 0x0600784A RID: 30794 RVA: 0x0020D64C File Offset: 0x0020B84C
		// (set) Token: 0x0600784B RID: 30795 RVA: 0x00038C00 File Offset: 0x00036E00
		public unsafe Il2CppReferenceArray<GameObject> ObjectsToActivate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveInRange.NativeFieldInfoPtr_ObjectsToActivate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveInRange.NativeFieldInfoPtr_ObjectsToActivate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700243A RID: 9274
		// (get) Token: 0x0600784C RID: 30796 RVA: 0x0020D67C File Offset: 0x0020B87C
		// (set) Token: 0x0600784D RID: 30797 RVA: 0x00038C1F File Offset: 0x00036E1F
		public unsafe bool Reverse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveInRange.NativeFieldInfoPtr_Reverse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveInRange.NativeFieldInfoPtr_Reverse)) = value;
			}
		}

		// Token: 0x1700243B RID: 9275
		// (get) Token: 0x0600784E RID: 30798 RVA: 0x0020D6A4 File Offset: 0x0020B8A4
		// (set) Token: 0x0600784F RID: 30799 RVA: 0x00038C3A File Offset: 0x00036E3A
		public unsafe bool isVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveInRange.NativeFieldInfoPtr_isVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveInRange.NativeFieldInfoPtr_isVisible)) = value;
			}
		}

		// Token: 0x04005230 RID: 21040
		private static readonly IntPtr NativeFieldInfoPtr_Distance;

		// Token: 0x04005231 RID: 21041
		private static readonly IntPtr NativeFieldInfoPtr_ScaleByLODBias;

		// Token: 0x04005232 RID: 21042
		private static readonly IntPtr NativeFieldInfoPtr_ObjectsToActivate;

		// Token: 0x04005233 RID: 21043
		private static readonly IntPtr NativeFieldInfoPtr_Reverse;

		// Token: 0x04005234 RID: 21044
		private static readonly IntPtr NativeFieldInfoPtr_isVisible;

		// Token: 0x04005235 RID: 21045
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04005236 RID: 21046
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
