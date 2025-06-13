using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200048B RID: 1163
	public class SetTransform : MonoBehaviour
	{
		// Token: 0x060063BC RID: 25532 RVA: 0x001C81F4 File Offset: 0x001C63F4
		// Note: this type is marked as 'beforefieldinit'.
		static SetTransform()
		{
			Il2CppClassPointerStore<SetTransform>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "SetTransform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetTransform>.NativeClassPtr);
			SetTransform.NativeFieldInfoPtr_SetOnAwake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, "SetOnAwake");
			SetTransform.NativeFieldInfoPtr_SetOnUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, "SetOnUpdate");
			SetTransform.NativeFieldInfoPtr_SetOnLateUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, "SetOnLateUpdate");
			SetTransform.NativeFieldInfoPtr_SetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, "SetPosition");
			SetTransform.NativeFieldInfoPtr_LocalPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, "LocalPosition");
			SetTransform.NativeFieldInfoPtr_SetRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, "SetRotation");
			SetTransform.NativeFieldInfoPtr_LocalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, "LocalRotation");
			SetTransform.NativeFieldInfoPtr_SetScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, "SetScale");
			SetTransform.NativeFieldInfoPtr_LocalScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, "LocalScale");
			SetTransform.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, 100676059);
			SetTransform.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, 100676060);
			SetTransform.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, 100676061);
			SetTransform.NativeMethodInfoPtr_Set_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, 100676062);
			SetTransform.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, 100676063);
		}

		// Token: 0x060063BD RID: 25533 RVA: 0x001C833C File Offset: 0x001C653C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205894, XrefRangeEnd = 205895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetTransform.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060063BE RID: 25534 RVA: 0x001C8370 File Offset: 0x001C6570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205895, XrefRangeEnd = 205896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetTransform.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060063BF RID: 25535 RVA: 0x001C83A4 File Offset: 0x001C65A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205896, XrefRangeEnd = 205897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetTransform.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060063C0 RID: 25536 RVA: 0x001C83D8 File Offset: 0x001C65D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 205912, RefRangeEnd = 205915, XrefRangeStart = 205897, XrefRangeEnd = 205912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetTransform.NativeMethodInfoPtr_Set_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060063C1 RID: 25537 RVA: 0x001C840C File Offset: 0x001C660C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205915, XrefRangeEnd = 205922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetTransform() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetTransform>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetTransform.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060063C2 RID: 25538 RVA: 0x0002EE54 File Offset: 0x0002D054
		public SetTransform(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001DCB RID: 7627
		// (get) Token: 0x060063C3 RID: 25539 RVA: 0x001C8448 File Offset: 0x001C6648
		// (set) Token: 0x060063C4 RID: 25540 RVA: 0x0002EE5D File Offset: 0x0002D05D
		public unsafe bool SetOnAwake
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_SetOnAwake);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_SetOnAwake)) = value;
			}
		}

		// Token: 0x17001DCC RID: 7628
		// (get) Token: 0x060063C5 RID: 25541 RVA: 0x001C8470 File Offset: 0x001C6670
		// (set) Token: 0x060063C6 RID: 25542 RVA: 0x0002EE78 File Offset: 0x0002D078
		public unsafe bool SetOnUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_SetOnUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_SetOnUpdate)) = value;
			}
		}

		// Token: 0x17001DCD RID: 7629
		// (get) Token: 0x060063C7 RID: 25543 RVA: 0x001C8498 File Offset: 0x001C6698
		// (set) Token: 0x060063C8 RID: 25544 RVA: 0x0002EE93 File Offset: 0x0002D093
		public unsafe bool SetOnLateUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_SetOnLateUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_SetOnLateUpdate)) = value;
			}
		}

		// Token: 0x17001DCE RID: 7630
		// (get) Token: 0x060063C9 RID: 25545 RVA: 0x001C84C0 File Offset: 0x001C66C0
		// (set) Token: 0x060063CA RID: 25546 RVA: 0x0002EEAE File Offset: 0x0002D0AE
		public unsafe bool SetPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_SetPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_SetPosition)) = value;
			}
		}

		// Token: 0x17001DCF RID: 7631
		// (get) Token: 0x060063CB RID: 25547 RVA: 0x001C84E8 File Offset: 0x001C66E8
		// (set) Token: 0x060063CC RID: 25548 RVA: 0x0002EEC9 File Offset: 0x0002D0C9
		public unsafe Vector3 LocalPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_LocalPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_LocalPosition)) = value;
			}
		}

		// Token: 0x17001DD0 RID: 7632
		// (get) Token: 0x060063CD RID: 25549 RVA: 0x001C8510 File Offset: 0x001C6710
		// (set) Token: 0x060063CE RID: 25550 RVA: 0x0002EEE4 File Offset: 0x0002D0E4
		public unsafe bool SetRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_SetRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_SetRotation)) = value;
			}
		}

		// Token: 0x17001DD1 RID: 7633
		// (get) Token: 0x060063CF RID: 25551 RVA: 0x001C8538 File Offset: 0x001C6738
		// (set) Token: 0x060063D0 RID: 25552 RVA: 0x0002EEFF File Offset: 0x0002D0FF
		public unsafe Vector3 LocalRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_LocalRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_LocalRotation)) = value;
			}
		}

		// Token: 0x17001DD2 RID: 7634
		// (get) Token: 0x060063D1 RID: 25553 RVA: 0x001C8560 File Offset: 0x001C6760
		// (set) Token: 0x060063D2 RID: 25554 RVA: 0x0002EF1A File Offset: 0x0002D11A
		public unsafe bool SetScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_SetScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_SetScale)) = value;
			}
		}

		// Token: 0x17001DD3 RID: 7635
		// (get) Token: 0x060063D3 RID: 25555 RVA: 0x001C8588 File Offset: 0x001C6788
		// (set) Token: 0x060063D4 RID: 25556 RVA: 0x0002EF35 File Offset: 0x0002D135
		public unsafe Vector3 LocalScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_LocalScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_LocalScale)) = value;
			}
		}

		// Token: 0x04004409 RID: 17417
		private static readonly IntPtr NativeFieldInfoPtr_SetOnAwake;

		// Token: 0x0400440A RID: 17418
		private static readonly IntPtr NativeFieldInfoPtr_SetOnUpdate;

		// Token: 0x0400440B RID: 17419
		private static readonly IntPtr NativeFieldInfoPtr_SetOnLateUpdate;

		// Token: 0x0400440C RID: 17420
		private static readonly IntPtr NativeFieldInfoPtr_SetPosition;

		// Token: 0x0400440D RID: 17421
		private static readonly IntPtr NativeFieldInfoPtr_LocalPosition;

		// Token: 0x0400440E RID: 17422
		private static readonly IntPtr NativeFieldInfoPtr_SetRotation;

		// Token: 0x0400440F RID: 17423
		private static readonly IntPtr NativeFieldInfoPtr_LocalRotation;

		// Token: 0x04004410 RID: 17424
		private static readonly IntPtr NativeFieldInfoPtr_SetScale;

		// Token: 0x04004411 RID: 17425
		private static readonly IntPtr NativeFieldInfoPtr_LocalScale;

		// Token: 0x04004412 RID: 17426
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004413 RID: 17427
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04004414 RID: 17428
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04004415 RID: 17429
		private static readonly IntPtr NativeMethodInfoPtr_Set_Private_Void_0;

		// Token: 0x04004416 RID: 17430
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
