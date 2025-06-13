using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework
{
	// Token: 0x0200061A RID: 1562
	public class Eyebrow : MonoBehaviour
	{
		// Token: 0x060088AB RID: 34987 RVA: 0x00244A14 File Offset: 0x00242C14
		// Note: this type is marked as 'beforefieldinit'.
		static Eyebrow()
		{
			Il2CppClassPointerStore<Eyebrow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework", "Eyebrow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr);
			Eyebrow.NativeFieldInfoPtr_eyebrowHeightMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, "eyebrowHeightMultiplier");
			Eyebrow.NativeFieldInfoPtr_EyebrowDefaultScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, "EyebrowDefaultScale");
			Eyebrow.NativeFieldInfoPtr_EyebrowDefaultLocalPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, "EyebrowDefaultLocalPos");
			Eyebrow.NativeFieldInfoPtr_Side = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, "Side");
			Eyebrow.NativeFieldInfoPtr_Model = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, "Model");
			Eyebrow.NativeFieldInfoPtr_Rend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, "Rend");
			Eyebrow.NativeFieldInfoPtr_col = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, "col");
			Eyebrow.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, "scale");
			Eyebrow.NativeFieldInfoPtr_thickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, "thickness");
			Eyebrow.NativeFieldInfoPtr_restingAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, "restingAngle");
			Eyebrow.NativeMethodInfoPtr_SetScale_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, 100680471);
			Eyebrow.NativeMethodInfoPtr_SetThickness_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, 100680472);
			Eyebrow.NativeMethodInfoPtr_SetRestingAngle_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, 100680473);
			Eyebrow.NativeMethodInfoPtr_SetRestingHeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, 100680474);
			Eyebrow.NativeMethodInfoPtr_SetColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, 100680475);
			Eyebrow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, 100680476);
		}

		// Token: 0x060088AC RID: 34988 RVA: 0x00244B84 File Offset: 0x00242D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254850, XrefRangeEnd = 254851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScale(float _scale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _scale;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eyebrow.NativeMethodInfoPtr_SetScale_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060088AD RID: 34989 RVA: 0x00244BC4 File Offset: 0x00242DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254851, XrefRangeEnd = 254852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetThickness(float thickness)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref thickness;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eyebrow.NativeMethodInfoPtr_SetThickness_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060088AE RID: 34990 RVA: 0x00244C04 File Offset: 0x00242E04
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 254860, RefRangeEnd = 254864, XrefRangeStart = 254852, XrefRangeEnd = 254860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRestingAngle(float _angle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _angle;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eyebrow.NativeMethodInfoPtr_SetRestingAngle_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060088AF RID: 34991 RVA: 0x00244C44 File Offset: 0x00242E44
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 254866, RefRangeEnd = 254872, XrefRangeStart = 254864, XrefRangeEnd = 254866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRestingHeight(float normalizedHeight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref normalizedHeight;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eyebrow.NativeMethodInfoPtr_SetRestingHeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060088B0 RID: 34992 RVA: 0x00244C84 File Offset: 0x00242E84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254872, XrefRangeEnd = 254874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColor(Color _col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _col;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eyebrow.NativeMethodInfoPtr_SetColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060088B1 RID: 34993 RVA: 0x00244CC4 File Offset: 0x00242EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254874, XrefRangeEnd = 254875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Eyebrow() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eyebrow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060088B2 RID: 34994 RVA: 0x00040B27 File Offset: 0x0003ED27
		public Eyebrow(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002950 RID: 10576
		// (get) Token: 0x060088B3 RID: 34995 RVA: 0x00244D00 File Offset: 0x00242F00
		// (set) Token: 0x060088B4 RID: 34996 RVA: 0x00040B30 File Offset: 0x0003ED30
		public unsafe static float eyebrowHeightMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Eyebrow.NativeFieldInfoPtr_eyebrowHeightMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Eyebrow.NativeFieldInfoPtr_eyebrowHeightMultiplier, (void*)(&value));
			}
		}

		// Token: 0x17002951 RID: 10577
		// (get) Token: 0x060088B5 RID: 34997 RVA: 0x00244D1C File Offset: 0x00242F1C
		// (set) Token: 0x060088B6 RID: 34998 RVA: 0x00040B3E File Offset: 0x0003ED3E
		public unsafe Vector3 EyebrowDefaultScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_EyebrowDefaultScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_EyebrowDefaultScale)) = value;
			}
		}

		// Token: 0x17002952 RID: 10578
		// (get) Token: 0x060088B7 RID: 34999 RVA: 0x00244D44 File Offset: 0x00242F44
		// (set) Token: 0x060088B8 RID: 35000 RVA: 0x00040B59 File Offset: 0x0003ED59
		public unsafe Vector3 EyebrowDefaultLocalPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_EyebrowDefaultLocalPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_EyebrowDefaultLocalPos)) = value;
			}
		}

		// Token: 0x17002953 RID: 10579
		// (get) Token: 0x060088B9 RID: 35001 RVA: 0x00244D6C File Offset: 0x00242F6C
		// (set) Token: 0x060088BA RID: 35002 RVA: 0x00040B74 File Offset: 0x0003ED74
		public unsafe Eyebrow.ESide Side
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_Side);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_Side)) = value;
			}
		}

		// Token: 0x17002954 RID: 10580
		// (get) Token: 0x060088BB RID: 35003 RVA: 0x00244D94 File Offset: 0x00242F94
		// (set) Token: 0x060088BC RID: 35004 RVA: 0x00040B8F File Offset: 0x0003ED8F
		public unsafe Transform Model
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_Model);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_Model), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002955 RID: 10581
		// (get) Token: 0x060088BD RID: 35005 RVA: 0x00244DC4 File Offset: 0x00242FC4
		// (set) Token: 0x060088BE RID: 35006 RVA: 0x00040BAE File Offset: 0x0003EDAE
		public unsafe MeshRenderer Rend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_Rend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_Rend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002956 RID: 10582
		// (get) Token: 0x060088BF RID: 35007 RVA: 0x00244DF4 File Offset: 0x00242FF4
		// (set) Token: 0x060088C0 RID: 35008 RVA: 0x00040BCD File Offset: 0x0003EDCD
		public unsafe Color col
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_col);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_col)) = value;
			}
		}

		// Token: 0x17002957 RID: 10583
		// (get) Token: 0x060088C1 RID: 35009 RVA: 0x00244E1C File Offset: 0x0024301C
		// (set) Token: 0x060088C2 RID: 35010 RVA: 0x00040BE8 File Offset: 0x0003EDE8
		public unsafe float scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_scale)) = value;
			}
		}

		// Token: 0x17002958 RID: 10584
		// (get) Token: 0x060088C3 RID: 35011 RVA: 0x00244E44 File Offset: 0x00243044
		// (set) Token: 0x060088C4 RID: 35012 RVA: 0x00040C03 File Offset: 0x0003EE03
		public unsafe float thickness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_thickness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_thickness)) = value;
			}
		}

		// Token: 0x17002959 RID: 10585
		// (get) Token: 0x060088C5 RID: 35013 RVA: 0x00244E6C File Offset: 0x0024306C
		// (set) Token: 0x060088C6 RID: 35014 RVA: 0x00040C1E File Offset: 0x0003EE1E
		public unsafe float restingAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_restingAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_restingAngle)) = value;
			}
		}

		// Token: 0x04005D10 RID: 23824
		private static readonly IntPtr NativeFieldInfoPtr_eyebrowHeightMultiplier;

		// Token: 0x04005D11 RID: 23825
		private static readonly IntPtr NativeFieldInfoPtr_EyebrowDefaultScale;

		// Token: 0x04005D12 RID: 23826
		private static readonly IntPtr NativeFieldInfoPtr_EyebrowDefaultLocalPos;

		// Token: 0x04005D13 RID: 23827
		private static readonly IntPtr NativeFieldInfoPtr_Side;

		// Token: 0x04005D14 RID: 23828
		private static readonly IntPtr NativeFieldInfoPtr_Model;

		// Token: 0x04005D15 RID: 23829
		private static readonly IntPtr NativeFieldInfoPtr_Rend;

		// Token: 0x04005D16 RID: 23830
		private static readonly IntPtr NativeFieldInfoPtr_col;

		// Token: 0x04005D17 RID: 23831
		private static readonly IntPtr NativeFieldInfoPtr_scale;

		// Token: 0x04005D18 RID: 23832
		private static readonly IntPtr NativeFieldInfoPtr_thickness;

		// Token: 0x04005D19 RID: 23833
		private static readonly IntPtr NativeFieldInfoPtr_restingAngle;

		// Token: 0x04005D1A RID: 23834
		private static readonly IntPtr NativeMethodInfoPtr_SetScale_Public_Void_Single_0;

		// Token: 0x04005D1B RID: 23835
		private static readonly IntPtr NativeMethodInfoPtr_SetThickness_Public_Void_Single_0;

		// Token: 0x04005D1C RID: 23836
		private static readonly IntPtr NativeMethodInfoPtr_SetRestingAngle_Public_Void_Single_0;

		// Token: 0x04005D1D RID: 23837
		private static readonly IntPtr NativeMethodInfoPtr_SetRestingHeight_Public_Void_Single_0;

		// Token: 0x04005D1E RID: 23838
		private static readonly IntPtr NativeMethodInfoPtr_SetColor_Public_Void_Color_0;

		// Token: 0x04005D1F RID: 23839
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B40 RID: 2880
		[OriginalName("Assembly-CSharp.dll", "", "ESide")]
		public enum ESide
		{
			// Token: 0x04009346 RID: 37702
			Right,
			// Token: 0x04009347 RID: 37703
			Left
		}
	}
}
