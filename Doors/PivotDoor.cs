using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Doors
{
	// Token: 0x02000448 RID: 1096
	public class PivotDoor : MonoBehaviour
	{
		// Token: 0x06005F61 RID: 24417 RVA: 0x001B9C7C File Offset: 0x001B7E7C
		// Note: this type is marked as 'beforefieldinit'.
		static PivotDoor()
		{
			Il2CppClassPointerStore<PivotDoor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Doors", "PivotDoor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PivotDoor>.NativeClassPtr);
			PivotDoor.NativeFieldInfoPtr_DoorTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PivotDoor>.NativeClassPtr, "DoorTransform");
			PivotDoor.NativeFieldInfoPtr_FlipSide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PivotDoor>.NativeClassPtr, "FlipSide");
			PivotDoor.NativeFieldInfoPtr_OpenInwardsAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PivotDoor>.NativeClassPtr, "OpenInwardsAngle");
			PivotDoor.NativeFieldInfoPtr_OpenOutwardsAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PivotDoor>.NativeClassPtr, "OpenOutwardsAngle");
			PivotDoor.NativeFieldInfoPtr_SwingSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PivotDoor>.NativeClassPtr, "SwingSpeed");
			PivotDoor.NativeFieldInfoPtr_targetDoorAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PivotDoor>.NativeClassPtr, "targetDoorAngle");
			PivotDoor.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotDoor>.NativeClassPtr, 100675534);
			PivotDoor.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotDoor>.NativeClassPtr, 100675535);
			PivotDoor.NativeMethodInfoPtr_Opened_Public_Virtual_New_Void_EDoorSide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotDoor>.NativeClassPtr, 100675536);
			PivotDoor.NativeMethodInfoPtr_Closed_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotDoor>.NativeClassPtr, 100675537);
			PivotDoor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotDoor>.NativeClassPtr, 100675538);
		}

		// Token: 0x06005F62 RID: 24418 RVA: 0x001B9D88 File Offset: 0x001B7F88
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotDoor.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005F63 RID: 24419 RVA: 0x001B9DC4 File Offset: 0x001B7FC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200431, XrefRangeEnd = 200436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PivotDoor.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005F64 RID: 24420 RVA: 0x001B9DF8 File Offset: 0x001B7FF8
		[CallerCount(0)]
		public unsafe virtual void Opened(EDoorSide openSide)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref openSide;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotDoor.NativeMethodInfoPtr_Opened_Public_Virtual_New_Void_EDoorSide_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005F65 RID: 24421 RVA: 0x001B9E44 File Offset: 0x001B8044
		[CallerCount(0)]
		public unsafe virtual void Closed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotDoor.NativeMethodInfoPtr_Closed_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005F66 RID: 24422 RVA: 0x001B9E80 File Offset: 0x001B8080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200436, XrefRangeEnd = 200437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PivotDoor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PivotDoor>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PivotDoor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005F67 RID: 24423 RVA: 0x0002CBC7 File Offset: 0x0002ADC7
		public PivotDoor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C84 RID: 7300
		// (get) Token: 0x06005F68 RID: 24424 RVA: 0x001B9EBC File Offset: 0x001B80BC
		// (set) Token: 0x06005F69 RID: 24425 RVA: 0x0002CBD0 File Offset: 0x0002ADD0
		public unsafe Transform DoorTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotDoor.NativeFieldInfoPtr_DoorTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotDoor.NativeFieldInfoPtr_DoorTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C85 RID: 7301
		// (get) Token: 0x06005F6A RID: 24426 RVA: 0x001B9EEC File Offset: 0x001B80EC
		// (set) Token: 0x06005F6B RID: 24427 RVA: 0x0002CBEF File Offset: 0x0002ADEF
		public unsafe bool FlipSide
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotDoor.NativeFieldInfoPtr_FlipSide);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotDoor.NativeFieldInfoPtr_FlipSide)) = value;
			}
		}

		// Token: 0x17001C86 RID: 7302
		// (get) Token: 0x06005F6C RID: 24428 RVA: 0x001B9F14 File Offset: 0x001B8114
		// (set) Token: 0x06005F6D RID: 24429 RVA: 0x0002CC0A File Offset: 0x0002AE0A
		public unsafe float OpenInwardsAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotDoor.NativeFieldInfoPtr_OpenInwardsAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotDoor.NativeFieldInfoPtr_OpenInwardsAngle)) = value;
			}
		}

		// Token: 0x17001C87 RID: 7303
		// (get) Token: 0x06005F6E RID: 24430 RVA: 0x001B9F3C File Offset: 0x001B813C
		// (set) Token: 0x06005F6F RID: 24431 RVA: 0x0002CC25 File Offset: 0x0002AE25
		public unsafe float OpenOutwardsAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotDoor.NativeFieldInfoPtr_OpenOutwardsAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotDoor.NativeFieldInfoPtr_OpenOutwardsAngle)) = value;
			}
		}

		// Token: 0x17001C88 RID: 7304
		// (get) Token: 0x06005F70 RID: 24432 RVA: 0x001B9F64 File Offset: 0x001B8164
		// (set) Token: 0x06005F71 RID: 24433 RVA: 0x0002CC40 File Offset: 0x0002AE40
		public unsafe float SwingSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotDoor.NativeFieldInfoPtr_SwingSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotDoor.NativeFieldInfoPtr_SwingSpeed)) = value;
			}
		}

		// Token: 0x17001C89 RID: 7305
		// (get) Token: 0x06005F72 RID: 24434 RVA: 0x001B9F8C File Offset: 0x001B818C
		// (set) Token: 0x06005F73 RID: 24435 RVA: 0x0002CC5B File Offset: 0x0002AE5B
		public unsafe float targetDoorAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotDoor.NativeFieldInfoPtr_targetDoorAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotDoor.NativeFieldInfoPtr_targetDoorAngle)) = value;
			}
		}

		// Token: 0x04004148 RID: 16712
		private static readonly IntPtr NativeFieldInfoPtr_DoorTransform;

		// Token: 0x04004149 RID: 16713
		private static readonly IntPtr NativeFieldInfoPtr_FlipSide;

		// Token: 0x0400414A RID: 16714
		private static readonly IntPtr NativeFieldInfoPtr_OpenInwardsAngle;

		// Token: 0x0400414B RID: 16715
		private static readonly IntPtr NativeFieldInfoPtr_OpenOutwardsAngle;

		// Token: 0x0400414C RID: 16716
		private static readonly IntPtr NativeFieldInfoPtr_SwingSpeed;

		// Token: 0x0400414D RID: 16717
		private static readonly IntPtr NativeFieldInfoPtr_targetDoorAngle;

		// Token: 0x0400414E RID: 16718
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x0400414F RID: 16719
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04004150 RID: 16720
		private static readonly IntPtr NativeMethodInfoPtr_Opened_Public_Virtual_New_Void_EDoorSide_0;

		// Token: 0x04004151 RID: 16721
		private static readonly IntPtr NativeMethodInfoPtr_Closed_Public_Virtual_New_Void_0;

		// Token: 0x04004152 RID: 16722
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
