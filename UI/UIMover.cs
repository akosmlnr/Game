using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000693 RID: 1683
	public class UIMover : MonoBehaviour
	{
		// Token: 0x0600953C RID: 38204 RVA: 0x002698B4 File Offset: 0x00267AB4
		// Note: this type is marked as 'beforefieldinit'.
		static UIMover()
		{
			Il2CppClassPointerStore<UIMover>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "UIMover");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIMover>.NativeClassPtr);
			UIMover.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIMover>.NativeClassPtr, "Rect");
			UIMover.NativeFieldInfoPtr_MinSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIMover>.NativeClassPtr, "MinSpeed");
			UIMover.NativeFieldInfoPtr_MaxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIMover>.NativeClassPtr, "MaxSpeed");
			UIMover.NativeFieldInfoPtr_SpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIMover>.NativeClassPtr, "SpeedMultiplier");
			UIMover.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIMover>.NativeClassPtr, "speed");
			UIMover.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIMover>.NativeClassPtr, 100681908);
			UIMover.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIMover>.NativeClassPtr, 100681909);
			UIMover.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIMover>.NativeClassPtr, 100681910);
		}

		// Token: 0x0600953D RID: 38205 RVA: 0x00269984 File Offset: 0x00267B84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268955, XrefRangeEnd = 268957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIMover.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600953E RID: 38206 RVA: 0x002699B8 File Offset: 0x00267BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268957, XrefRangeEnd = 268961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIMover.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600953F RID: 38207 RVA: 0x002699EC File Offset: 0x00267BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268961, XrefRangeEnd = 268968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIMover() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIMover>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIMover.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009540 RID: 38208 RVA: 0x00047FB5 File Offset: 0x000461B5
		public UIMover(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D86 RID: 11654
		// (get) Token: 0x06009541 RID: 38209 RVA: 0x00269A28 File Offset: 0x00267C28
		// (set) Token: 0x06009542 RID: 38210 RVA: 0x00047FBE File Offset: 0x000461BE
		public unsafe RectTransform Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMover.NativeFieldInfoPtr_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMover.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D87 RID: 11655
		// (get) Token: 0x06009543 RID: 38211 RVA: 0x00269A58 File Offset: 0x00267C58
		// (set) Token: 0x06009544 RID: 38212 RVA: 0x00047FDD File Offset: 0x000461DD
		public unsafe Vector2 MinSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMover.NativeFieldInfoPtr_MinSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMover.NativeFieldInfoPtr_MinSpeed)) = value;
			}
		}

		// Token: 0x17002D88 RID: 11656
		// (get) Token: 0x06009545 RID: 38213 RVA: 0x00269A80 File Offset: 0x00267C80
		// (set) Token: 0x06009546 RID: 38214 RVA: 0x00047FF8 File Offset: 0x000461F8
		public unsafe Vector2 MaxSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMover.NativeFieldInfoPtr_MaxSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMover.NativeFieldInfoPtr_MaxSpeed)) = value;
			}
		}

		// Token: 0x17002D89 RID: 11657
		// (get) Token: 0x06009547 RID: 38215 RVA: 0x00269AA8 File Offset: 0x00267CA8
		// (set) Token: 0x06009548 RID: 38216 RVA: 0x00048013 File Offset: 0x00046213
		public unsafe float SpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMover.NativeFieldInfoPtr_SpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMover.NativeFieldInfoPtr_SpeedMultiplier)) = value;
			}
		}

		// Token: 0x17002D8A RID: 11658
		// (get) Token: 0x06009549 RID: 38217 RVA: 0x00269AD0 File Offset: 0x00267CD0
		// (set) Token: 0x0600954A RID: 38218 RVA: 0x0004802E File Offset: 0x0004622E
		public unsafe Vector2 speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMover.NativeFieldInfoPtr_speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMover.NativeFieldInfoPtr_speed)) = value;
			}
		}

		// Token: 0x040064D1 RID: 25809
		private static readonly IntPtr NativeFieldInfoPtr_Rect;

		// Token: 0x040064D2 RID: 25810
		private static readonly IntPtr NativeFieldInfoPtr_MinSpeed;

		// Token: 0x040064D3 RID: 25811
		private static readonly IntPtr NativeFieldInfoPtr_MaxSpeed;

		// Token: 0x040064D4 RID: 25812
		private static readonly IntPtr NativeFieldInfoPtr_SpeedMultiplier;

		// Token: 0x040064D5 RID: 25813
		private static readonly IntPtr NativeFieldInfoPtr_speed;

		// Token: 0x040064D6 RID: 25814
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040064D7 RID: 25815
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x040064D8 RID: 25816
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
