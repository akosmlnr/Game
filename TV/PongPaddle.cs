using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.TV
{
	// Token: 0x02000192 RID: 402
	public class PongPaddle : MonoBehaviour
	{
		// Token: 0x06001FE3 RID: 8163 RVA: 0x000D6EAC File Offset: 0x000D50AC
		// Note: this type is marked as 'beforefieldinit'.
		static PongPaddle()
		{
			Il2CppClassPointerStore<PongPaddle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.TV", "PongPaddle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PongPaddle>.NativeClassPtr);
			PongPaddle.NativeFieldInfoPtr_BOUND_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PongPaddle>.NativeClassPtr, "BOUND_Y");
			PongPaddle.NativeFieldInfoPtr_MOVE_SPEED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PongPaddle>.NativeClassPtr, "MOVE_SPEED");
			PongPaddle.NativeFieldInfoPtr_SpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PongPaddle>.NativeClassPtr, "SpeedMultiplier");
			PongPaddle.NativeFieldInfoPtr__TargetY_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PongPaddle>.NativeClassPtr, "<TargetY>k__BackingField");
			PongPaddle.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PongPaddle>.NativeClassPtr, "Rect");
			PongPaddle.NativeMethodInfoPtr_get_TargetY_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PongPaddle>.NativeClassPtr, 100666925);
			PongPaddle.NativeMethodInfoPtr_set_TargetY_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PongPaddle>.NativeClassPtr, 100666926);
			PongPaddle.NativeMethodInfoPtr_SetTargetY_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PongPaddle>.NativeClassPtr, 100666927);
			PongPaddle.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PongPaddle>.NativeClassPtr, 100666928);
			PongPaddle.NativeMethodInfoPtr_UpdateMove_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PongPaddle>.NativeClassPtr, 100666929);
			PongPaddle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PongPaddle>.NativeClassPtr, 100666930);
		}

		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x06001FE4 RID: 8164 RVA: 0x000D6FB8 File Offset: 0x000D51B8
		// (set) Token: 0x06001FE5 RID: 8165 RVA: 0x000D6FF4 File Offset: 0x000D51F4
		public unsafe float TargetY
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PongPaddle.NativeMethodInfoPtr_get_TargetY_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 31412, RefRangeEnd = 31426, XrefRangeStart = 31412, XrefRangeEnd = 31426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PongPaddle.NativeMethodInfoPtr_set_TargetY_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06001FE6 RID: 8166 RVA: 0x000D7034 File Offset: 0x000D5234
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 31412, RefRangeEnd = 31426, XrefRangeStart = 31412, XrefRangeEnd = 31426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetY(float y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref y;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PongPaddle.NativeMethodInfoPtr_SetTargetY_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001FE7 RID: 8167 RVA: 0x000D7074 File Offset: 0x000D5274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111753, XrefRangeEnd = 111759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PongPaddle.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001FE8 RID: 8168 RVA: 0x000D70A8 File Offset: 0x000D52A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PongPaddle.NativeMethodInfoPtr_UpdateMove_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001FE9 RID: 8169 RVA: 0x000D70DC File Offset: 0x000D52DC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 77482, RefRangeEnd = 77486, XrefRangeStart = 77482, XrefRangeEnd = 77486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PongPaddle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PongPaddle>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PongPaddle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001FEA RID: 8170 RVA: 0x00011D45 File Offset: 0x0000FF45
		public PongPaddle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x06001FEB RID: 8171 RVA: 0x000D7118 File Offset: 0x000D5318
		// (set) Token: 0x06001FEC RID: 8172 RVA: 0x00011D4E File Offset: 0x0000FF4E
		public unsafe static float BOUND_Y
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PongPaddle.NativeFieldInfoPtr_BOUND_Y, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PongPaddle.NativeFieldInfoPtr_BOUND_Y, (void*)(&value));
			}
		}

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x06001FED RID: 8173 RVA: 0x000D7134 File Offset: 0x000D5334
		// (set) Token: 0x06001FEE RID: 8174 RVA: 0x00011D5C File Offset: 0x0000FF5C
		public unsafe static float MOVE_SPEED
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PongPaddle.NativeFieldInfoPtr_MOVE_SPEED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PongPaddle.NativeFieldInfoPtr_MOVE_SPEED, (void*)(&value));
			}
		}

		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x06001FEF RID: 8175 RVA: 0x000D7150 File Offset: 0x000D5350
		// (set) Token: 0x06001FF0 RID: 8176 RVA: 0x00011D6A File Offset: 0x0000FF6A
		public unsafe float SpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PongPaddle.NativeFieldInfoPtr_SpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PongPaddle.NativeFieldInfoPtr_SpeedMultiplier)) = value;
			}
		}

		// Token: 0x17000AE6 RID: 2790
		// (get) Token: 0x06001FF1 RID: 8177 RVA: 0x000D7178 File Offset: 0x000D5378
		// (set) Token: 0x06001FF2 RID: 8178 RVA: 0x00011D85 File Offset: 0x0000FF85
		public unsafe float _TargetY_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PongPaddle.NativeFieldInfoPtr__TargetY_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PongPaddle.NativeFieldInfoPtr__TargetY_k__BackingField)) = value;
			}
		}

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x06001FF3 RID: 8179 RVA: 0x000D71A0 File Offset: 0x000D53A0
		// (set) Token: 0x06001FF4 RID: 8180 RVA: 0x00011DA0 File Offset: 0x0000FFA0
		public unsafe RectTransform Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PongPaddle.NativeFieldInfoPtr_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PongPaddle.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400152D RID: 5421
		private static readonly IntPtr NativeFieldInfoPtr_BOUND_Y;

		// Token: 0x0400152E RID: 5422
		private static readonly IntPtr NativeFieldInfoPtr_MOVE_SPEED;

		// Token: 0x0400152F RID: 5423
		private static readonly IntPtr NativeFieldInfoPtr_SpeedMultiplier;

		// Token: 0x04001530 RID: 5424
		private static readonly IntPtr NativeFieldInfoPtr__TargetY_k__BackingField;

		// Token: 0x04001531 RID: 5425
		private static readonly IntPtr NativeFieldInfoPtr_Rect;

		// Token: 0x04001532 RID: 5426
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetY_Public_get_Single_0;

		// Token: 0x04001533 RID: 5427
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetY_Public_set_Void_Single_0;

		// Token: 0x04001534 RID: 5428
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetY_Public_Void_Single_0;

		// Token: 0x04001535 RID: 5429
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001536 RID: 5430
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMove_Private_Void_0;

		// Token: 0x04001537 RID: 5431
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
