using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000574 RID: 1396
	public class SmoothRotate : MonoBehaviour
	{
		// Token: 0x06007A0D RID: 31245 RVA: 0x002127C8 File Offset: 0x002109C8
		// Note: this type is marked as 'beforefieldinit'.
		static SmoothRotate()
		{
			Il2CppClassPointerStore<SmoothRotate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "SmoothRotate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmoothRotate>.NativeClassPtr);
			SmoothRotate.NativeFieldInfoPtr_Active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothRotate>.NativeClassPtr, "Active");
			SmoothRotate.NativeFieldInfoPtr_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothRotate>.NativeClassPtr, "Speed");
			SmoothRotate.NativeFieldInfoPtr_Aceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothRotate>.NativeClassPtr, "Aceleration");
			SmoothRotate.NativeFieldInfoPtr_Axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothRotate>.NativeClassPtr, "Axis");
			SmoothRotate.NativeFieldInfoPtr_currentSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothRotate>.NativeClassPtr, "currentSpeed");
			SmoothRotate.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothRotate>.NativeClassPtr, 100678742);
			SmoothRotate.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothRotate>.NativeClassPtr, 100678743);
			SmoothRotate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothRotate>.NativeClassPtr, 100678744);
		}

		// Token: 0x06007A0E RID: 31246 RVA: 0x00212898 File Offset: 0x00210A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236019, XrefRangeEnd = 236026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothRotate.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007A0F RID: 31247 RVA: 0x002128CC File Offset: 0x00210ACC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 37514, RefRangeEnd = 37516, XrefRangeStart = 37514, XrefRangeEnd = 37516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothRotate.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007A10 RID: 31248 RVA: 0x0021290C File Offset: 0x00210B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236026, XrefRangeEnd = 236029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SmoothRotate() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmoothRotate>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothRotate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007A11 RID: 31249 RVA: 0x00039967 File Offset: 0x00037B67
		public SmoothRotate(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024AF RID: 9391
		// (get) Token: 0x06007A12 RID: 31250 RVA: 0x00212948 File Offset: 0x00210B48
		// (set) Token: 0x06007A13 RID: 31251 RVA: 0x00039970 File Offset: 0x00037B70
		public unsafe bool Active
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothRotate.NativeFieldInfoPtr_Active);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothRotate.NativeFieldInfoPtr_Active)) = value;
			}
		}

		// Token: 0x170024B0 RID: 9392
		// (get) Token: 0x06007A14 RID: 31252 RVA: 0x00212970 File Offset: 0x00210B70
		// (set) Token: 0x06007A15 RID: 31253 RVA: 0x0003998B File Offset: 0x00037B8B
		public unsafe float Speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothRotate.NativeFieldInfoPtr_Speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothRotate.NativeFieldInfoPtr_Speed)) = value;
			}
		}

		// Token: 0x170024B1 RID: 9393
		// (get) Token: 0x06007A16 RID: 31254 RVA: 0x00212998 File Offset: 0x00210B98
		// (set) Token: 0x06007A17 RID: 31255 RVA: 0x000399A6 File Offset: 0x00037BA6
		public unsafe float Aceleration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothRotate.NativeFieldInfoPtr_Aceleration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothRotate.NativeFieldInfoPtr_Aceleration)) = value;
			}
		}

		// Token: 0x170024B2 RID: 9394
		// (get) Token: 0x06007A18 RID: 31256 RVA: 0x002129C0 File Offset: 0x00210BC0
		// (set) Token: 0x06007A19 RID: 31257 RVA: 0x000399C1 File Offset: 0x00037BC1
		public unsafe Vector3 Axis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothRotate.NativeFieldInfoPtr_Axis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothRotate.NativeFieldInfoPtr_Axis)) = value;
			}
		}

		// Token: 0x170024B3 RID: 9395
		// (get) Token: 0x06007A1A RID: 31258 RVA: 0x002129E8 File Offset: 0x00210BE8
		// (set) Token: 0x06007A1B RID: 31259 RVA: 0x000399DC File Offset: 0x00037BDC
		public unsafe float currentSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothRotate.NativeFieldInfoPtr_currentSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothRotate.NativeFieldInfoPtr_currentSpeed)) = value;
			}
		}

		// Token: 0x0400533D RID: 21309
		private static readonly IntPtr NativeFieldInfoPtr_Active;

		// Token: 0x0400533E RID: 21310
		private static readonly IntPtr NativeFieldInfoPtr_Speed;

		// Token: 0x0400533F RID: 21311
		private static readonly IntPtr NativeFieldInfoPtr_Aceleration;

		// Token: 0x04005340 RID: 21312
		private static readonly IntPtr NativeFieldInfoPtr_Axis;

		// Token: 0x04005341 RID: 21313
		private static readonly IntPtr NativeFieldInfoPtr_currentSpeed;

		// Token: 0x04005342 RID: 21314
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04005343 RID: 21315
		private static readonly IntPtr NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0;

		// Token: 0x04005344 RID: 21316
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
