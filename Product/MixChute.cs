using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Interaction;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005D5 RID: 1493
	public class MixChute : MonoBehaviour
	{
		// Token: 0x06008237 RID: 33335 RVA: 0x0022F924 File Offset: 0x0022DB24
		// Note: this type is marked as 'beforefieldinit'.
		static MixChute()
		{
			Il2CppClassPointerStore<MixChute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "MixChute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixChute>.NativeClassPtr);
			MixChute.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixChute>.NativeClassPtr, "IntObj");
			MixChute.NativeFieldInfoPtr_DoorAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixChute>.NativeClassPtr, "DoorAnim");
			MixChute.NativeFieldInfoPtr_isDoorOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixChute>.NativeClassPtr, "isDoorOpen");
			MixChute.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixChute>.NativeClassPtr, 100679755);
			MixChute.NativeMethodInfoPtr_UpdateDoor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixChute>.NativeClassPtr, 100679756);
			MixChute.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixChute>.NativeClassPtr, 100679757);
			MixChute.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixChute>.NativeClassPtr, 100679758);
			MixChute.NativeMethodInfoPtr_SetDoorOpen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixChute>.NativeClassPtr, 100679759);
			MixChute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixChute>.NativeClassPtr, 100679760);
		}

		// Token: 0x06008238 RID: 33336 RVA: 0x0022FA08 File Offset: 0x0022DC08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247663, XrefRangeEnd = 247671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixChute.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008239 RID: 33337 RVA: 0x0022FA3C File Offset: 0x0022DC3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 247687, RefRangeEnd = 247688, XrefRangeStart = 247671, XrefRangeEnd = 247687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDoor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixChute.NativeMethodInfoPtr_UpdateDoor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600823A RID: 33338 RVA: 0x0022FA70 File Offset: 0x0022DC70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247688, XrefRangeEnd = 247700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixChute.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600823B RID: 33339 RVA: 0x0022FAA4 File Offset: 0x0022DCA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247700, XrefRangeEnd = 247712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixChute.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600823C RID: 33340 RVA: 0x0022FAD8 File Offset: 0x0022DCD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247712, XrefRangeEnd = 247718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDoorOpen(bool isOpen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isOpen;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixChute.NativeMethodInfoPtr_SetDoorOpen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600823D RID: 33341 RVA: 0x0022FB18 File Offset: 0x0022DD18
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixChute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixChute>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixChute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600823E RID: 33342 RVA: 0x0003D761 File Offset: 0x0003B961
		public MixChute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700271D RID: 10013
		// (get) Token: 0x0600823F RID: 33343 RVA: 0x0022FB54 File Offset: 0x0022DD54
		// (set) Token: 0x06008240 RID: 33344 RVA: 0x0003D76A File Offset: 0x0003B96A
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixChute.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixChute.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700271E RID: 10014
		// (get) Token: 0x06008241 RID: 33345 RVA: 0x0022FB84 File Offset: 0x0022DD84
		// (set) Token: 0x06008242 RID: 33346 RVA: 0x0003D789 File Offset: 0x0003B989
		public unsafe Animation DoorAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixChute.NativeFieldInfoPtr_DoorAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixChute.NativeFieldInfoPtr_DoorAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700271F RID: 10015
		// (get) Token: 0x06008243 RID: 33347 RVA: 0x0022FBB4 File Offset: 0x0022DDB4
		// (set) Token: 0x06008244 RID: 33348 RVA: 0x0003D7A8 File Offset: 0x0003B9A8
		public unsafe bool isDoorOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixChute.NativeFieldInfoPtr_isDoorOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixChute.NativeFieldInfoPtr_isDoorOpen)) = value;
			}
		}

		// Token: 0x040058BE RID: 22718
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x040058BF RID: 22719
		private static readonly IntPtr NativeFieldInfoPtr_DoorAnim;

		// Token: 0x040058C0 RID: 22720
		private static readonly IntPtr NativeFieldInfoPtr_isDoorOpen;

		// Token: 0x040058C1 RID: 22721
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040058C2 RID: 22722
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDoor_Private_Void_0;

		// Token: 0x040058C3 RID: 22723
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x040058C4 RID: 22724
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x040058C5 RID: 22725
		private static readonly IntPtr NativeMethodInfoPtr_SetDoorOpen_Public_Void_Boolean_0;

		// Token: 0x040058C6 RID: 22726
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
