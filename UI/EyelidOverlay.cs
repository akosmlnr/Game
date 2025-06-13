using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Tools;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200067B RID: 1659
	public class EyelidOverlay : Singleton<EyelidOverlay>
	{
		// Token: 0x0600931F RID: 37663 RVA: 0x00263328 File Offset: 0x00261528
		// Note: this type is marked as 'beforefieldinit'.
		static EyelidOverlay()
		{
			Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "EyelidOverlay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr);
			EyelidOverlay.NativeFieldInfoPtr_MaxTiredOpenAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, "MaxTiredOpenAmount");
			EyelidOverlay.NativeFieldInfoPtr_AutoUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, "AutoUpdate");
			EyelidOverlay.NativeFieldInfoPtr_Open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, "Open");
			EyelidOverlay.NativeFieldInfoPtr_Closed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, "Closed");
			EyelidOverlay.NativeFieldInfoPtr_Upper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, "Upper");
			EyelidOverlay.NativeFieldInfoPtr_Lower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, "Lower");
			EyelidOverlay.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, "Canvas");
			EyelidOverlay.NativeFieldInfoPtr_CurrentOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, "CurrentOpen");
			EyelidOverlay.NativeFieldInfoPtr_OpenMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, "OpenMultiplier");
			EyelidOverlay.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, 100681624);
			EyelidOverlay.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, 100681625);
			EyelidOverlay.NativeMethodInfoPtr_SetOpen_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, 100681626);
			EyelidOverlay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, 100681627);
		}

		// Token: 0x06009320 RID: 37664 RVA: 0x0026345C File Offset: 0x0026165C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266145, XrefRangeEnd = 266151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EyelidOverlay.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009321 RID: 37665 RVA: 0x00263498 File Offset: 0x00261698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266151, XrefRangeEnd = 266167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyelidOverlay.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009322 RID: 37666 RVA: 0x002634CC File Offset: 0x002616CC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 266175, RefRangeEnd = 266180, XrefRangeStart = 266167, XrefRangeEnd = 266175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOpen(float openness)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref openness;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyelidOverlay.NativeMethodInfoPtr_SetOpen_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009323 RID: 37667 RVA: 0x0026350C File Offset: 0x0026170C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266180, XrefRangeEnd = 266183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EyelidOverlay() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyelidOverlay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009324 RID: 37668 RVA: 0x00046CDA File Offset: 0x00044EDA
		public EyelidOverlay(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002CD9 RID: 11481
		// (get) Token: 0x06009325 RID: 37669 RVA: 0x00263548 File Offset: 0x00261748
		// (set) Token: 0x06009326 RID: 37670 RVA: 0x00046CE3 File Offset: 0x00044EE3
		public unsafe static float MaxTiredOpenAmount
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(EyelidOverlay.NativeFieldInfoPtr_MaxTiredOpenAmount, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EyelidOverlay.NativeFieldInfoPtr_MaxTiredOpenAmount, (void*)(&value));
			}
		}

		// Token: 0x17002CDA RID: 11482
		// (get) Token: 0x06009327 RID: 37671 RVA: 0x00263564 File Offset: 0x00261764
		// (set) Token: 0x06009328 RID: 37672 RVA: 0x00046CF1 File Offset: 0x00044EF1
		public unsafe bool AutoUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_AutoUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_AutoUpdate)) = value;
			}
		}

		// Token: 0x17002CDB RID: 11483
		// (get) Token: 0x06009329 RID: 37673 RVA: 0x0026358C File Offset: 0x0026178C
		// (set) Token: 0x0600932A RID: 37674 RVA: 0x00046D0C File Offset: 0x00044F0C
		public unsafe float Open
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_Open);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_Open)) = value;
			}
		}

		// Token: 0x17002CDC RID: 11484
		// (get) Token: 0x0600932B RID: 37675 RVA: 0x002635B4 File Offset: 0x002617B4
		// (set) Token: 0x0600932C RID: 37676 RVA: 0x00046D27 File Offset: 0x00044F27
		public unsafe float Closed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_Closed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_Closed)) = value;
			}
		}

		// Token: 0x17002CDD RID: 11485
		// (get) Token: 0x0600932D RID: 37677 RVA: 0x002635DC File Offset: 0x002617DC
		// (set) Token: 0x0600932E RID: 37678 RVA: 0x00046D42 File Offset: 0x00044F42
		public unsafe RectTransform Upper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_Upper);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_Upper), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CDE RID: 11486
		// (get) Token: 0x0600932F RID: 37679 RVA: 0x0026360C File Offset: 0x0026180C
		// (set) Token: 0x06009330 RID: 37680 RVA: 0x00046D61 File Offset: 0x00044F61
		public unsafe RectTransform Lower
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_Lower);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_Lower), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CDF RID: 11487
		// (get) Token: 0x06009331 RID: 37681 RVA: 0x0026363C File Offset: 0x0026183C
		// (set) Token: 0x06009332 RID: 37682 RVA: 0x00046D80 File Offset: 0x00044F80
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CE0 RID: 11488
		// (get) Token: 0x06009333 RID: 37683 RVA: 0x0026366C File Offset: 0x0026186C
		// (set) Token: 0x06009334 RID: 37684 RVA: 0x00046D9F File Offset: 0x00044F9F
		public unsafe float CurrentOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_CurrentOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_CurrentOpen)) = value;
			}
		}

		// Token: 0x17002CE1 RID: 11489
		// (get) Token: 0x06009335 RID: 37685 RVA: 0x00263694 File Offset: 0x00261894
		// (set) Token: 0x06009336 RID: 37686 RVA: 0x00046DBA File Offset: 0x00044FBA
		public unsafe FloatSmoother OpenMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_OpenMultiplier);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_OpenMultiplier), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006381 RID: 25473
		private static readonly IntPtr NativeFieldInfoPtr_MaxTiredOpenAmount;

		// Token: 0x04006382 RID: 25474
		private static readonly IntPtr NativeFieldInfoPtr_AutoUpdate;

		// Token: 0x04006383 RID: 25475
		private static readonly IntPtr NativeFieldInfoPtr_Open;

		// Token: 0x04006384 RID: 25476
		private static readonly IntPtr NativeFieldInfoPtr_Closed;

		// Token: 0x04006385 RID: 25477
		private static readonly IntPtr NativeFieldInfoPtr_Upper;

		// Token: 0x04006386 RID: 25478
		private static readonly IntPtr NativeFieldInfoPtr_Lower;

		// Token: 0x04006387 RID: 25479
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04006388 RID: 25480
		private static readonly IntPtr NativeFieldInfoPtr_CurrentOpen;

		// Token: 0x04006389 RID: 25481
		private static readonly IntPtr NativeFieldInfoPtr_OpenMultiplier;

		// Token: 0x0400638A RID: 25482
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400638B RID: 25483
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400638C RID: 25484
		private static readonly IntPtr NativeMethodInfoPtr_SetOpen_Public_Void_Single_0;

		// Token: 0x0400638D RID: 25485
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
