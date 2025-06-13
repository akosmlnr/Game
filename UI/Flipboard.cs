using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200065F RID: 1631
	public class Flipboard : MonoBehaviour
	{
		// Token: 0x06008F28 RID: 36648 RVA: 0x00257B74 File Offset: 0x00255D74
		// Note: this type is marked as 'beforefieldinit'.
		static Flipboard()
		{
			Il2CppClassPointerStore<Flipboard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "Flipboard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Flipboard>.NativeClassPtr);
			Flipboard.NativeFieldInfoPtr_Sprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Flipboard>.NativeClassPtr, "Sprites");
			Flipboard.NativeFieldInfoPtr_Image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Flipboard>.NativeClassPtr, "Image");
			Flipboard.NativeFieldInfoPtr_FlipTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Flipboard>.NativeClassPtr, "FlipTime");
			Flipboard.NativeFieldInfoPtr_SpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Flipboard>.NativeClassPtr, "SpeedMultiplier");
			Flipboard.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Flipboard>.NativeClassPtr, "time");
			Flipboard.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Flipboard>.NativeClassPtr, "index");
			Flipboard.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Flipboard>.NativeClassPtr, 100681179);
			Flipboard.NativeMethodInfoPtr_SetIndex_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Flipboard>.NativeClassPtr, 100681180);
			Flipboard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Flipboard>.NativeClassPtr, 100681181);
		}

		// Token: 0x06008F29 RID: 36649 RVA: 0x00257C58 File Offset: 0x00255E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261221, XrefRangeEnd = 261223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Flipboard.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008F2A RID: 36650 RVA: 0x00257C8C File Offset: 0x00255E8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 261226, RefRangeEnd = 261227, XrefRangeStart = 261223, XrefRangeEnd = 261226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Flipboard.NativeMethodInfoPtr_SetIndex_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008F2B RID: 36651 RVA: 0x00257CCC File Offset: 0x00255ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261227, XrefRangeEnd = 261228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Flipboard() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Flipboard>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Flipboard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008F2C RID: 36652 RVA: 0x0004464E File Offset: 0x0004284E
		public Flipboard(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002B73 RID: 11123
		// (get) Token: 0x06008F2D RID: 36653 RVA: 0x00257D08 File Offset: 0x00255F08
		// (set) Token: 0x06008F2E RID: 36654 RVA: 0x00044657 File Offset: 0x00042857
		public unsafe Il2CppReferenceArray<Sprite> Sprites
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Flipboard.NativeFieldInfoPtr_Sprites);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Flipboard.NativeFieldInfoPtr_Sprites), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B74 RID: 11124
		// (get) Token: 0x06008F2F RID: 36655 RVA: 0x00257D38 File Offset: 0x00255F38
		// (set) Token: 0x06008F30 RID: 36656 RVA: 0x00044676 File Offset: 0x00042876
		public unsafe Image Image
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Flipboard.NativeFieldInfoPtr_Image);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Flipboard.NativeFieldInfoPtr_Image), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B75 RID: 11125
		// (get) Token: 0x06008F31 RID: 36657 RVA: 0x00257D68 File Offset: 0x00255F68
		// (set) Token: 0x06008F32 RID: 36658 RVA: 0x00044695 File Offset: 0x00042895
		public unsafe float FlipTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Flipboard.NativeFieldInfoPtr_FlipTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Flipboard.NativeFieldInfoPtr_FlipTime)) = value;
			}
		}

		// Token: 0x17002B76 RID: 11126
		// (get) Token: 0x06008F33 RID: 36659 RVA: 0x00257D90 File Offset: 0x00255F90
		// (set) Token: 0x06008F34 RID: 36660 RVA: 0x000446B0 File Offset: 0x000428B0
		public unsafe float SpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Flipboard.NativeFieldInfoPtr_SpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Flipboard.NativeFieldInfoPtr_SpeedMultiplier)) = value;
			}
		}

		// Token: 0x17002B77 RID: 11127
		// (get) Token: 0x06008F35 RID: 36661 RVA: 0x00257DB8 File Offset: 0x00255FB8
		// (set) Token: 0x06008F36 RID: 36662 RVA: 0x000446CB File Offset: 0x000428CB
		public unsafe float time
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Flipboard.NativeFieldInfoPtr_time);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Flipboard.NativeFieldInfoPtr_time)) = value;
			}
		}

		// Token: 0x17002B78 RID: 11128
		// (get) Token: 0x06008F37 RID: 36663 RVA: 0x00257DE0 File Offset: 0x00255FE0
		// (set) Token: 0x06008F38 RID: 36664 RVA: 0x000446E6 File Offset: 0x000428E6
		public unsafe int index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Flipboard.NativeFieldInfoPtr_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Flipboard.NativeFieldInfoPtr_index)) = value;
			}
		}

		// Token: 0x0400610B RID: 24843
		private static readonly IntPtr NativeFieldInfoPtr_Sprites;

		// Token: 0x0400610C RID: 24844
		private static readonly IntPtr NativeFieldInfoPtr_Image;

		// Token: 0x0400610D RID: 24845
		private static readonly IntPtr NativeFieldInfoPtr_FlipTime;

		// Token: 0x0400610E RID: 24846
		private static readonly IntPtr NativeFieldInfoPtr_SpeedMultiplier;

		// Token: 0x0400610F RID: 24847
		private static readonly IntPtr NativeFieldInfoPtr_time;

		// Token: 0x04006110 RID: 24848
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x04006111 RID: 24849
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04006112 RID: 24850
		private static readonly IntPtr NativeMethodInfoPtr_SetIndex_Public_Void_Int32_0;

		// Token: 0x04006113 RID: 24851
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
