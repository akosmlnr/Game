using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004EB RID: 1259
	public class AmbientOneShot : MonoBehaviour
	{
		// Token: 0x06006D17 RID: 27927 RVA: 0x001E82E8 File Offset: 0x001E64E8
		// Note: this type is marked as 'beforefieldinit'.
		static AmbientOneShot()
		{
			Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "AmbientOneShot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr);
			AmbientOneShot.NativeFieldInfoPtr_Audio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, "Audio");
			AmbientOneShot.NativeFieldInfoPtr_Volume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, "Volume");
			AmbientOneShot.NativeFieldInfoPtr_ChancePerHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, "ChancePerHour");
			AmbientOneShot.NativeFieldInfoPtr_CooldownTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, "CooldownTime");
			AmbientOneShot.NativeFieldInfoPtr_PlayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, "PlayTime");
			AmbientOneShot.NativeFieldInfoPtr_MinDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, "MinDistance");
			AmbientOneShot.NativeFieldInfoPtr_MaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, "MaxDistance");
			AmbientOneShot.NativeFieldInfoPtr_timeSinceLastPlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, "timeSinceLastPlay");
			AmbientOneShot.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, 100677206);
			AmbientOneShot.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, 100677207);
			AmbientOneShot.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, 100677208);
			AmbientOneShot.NativeMethodInfoPtr_Play_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, 100677209);
			AmbientOneShot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, 100677210);
		}

		// Token: 0x06006D18 RID: 27928 RVA: 0x001E841C File Offset: 0x001E661C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219818, XrefRangeEnd = 219836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientOneShot.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006D19 RID: 27929 RVA: 0x001E8450 File Offset: 0x001E6650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219836, XrefRangeEnd = 219844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmosSelected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientOneShot.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006D1A RID: 27930 RVA: 0x001E8484 File Offset: 0x001E6684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219844, XrefRangeEnd = 219868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientOneShot.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006D1B RID: 27931 RVA: 0x001E84B8 File Offset: 0x001E66B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219868, XrefRangeEnd = 219870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientOneShot.NativeMethodInfoPtr_Play_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006D1C RID: 27932 RVA: 0x001E84EC File Offset: 0x001E66EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219870, XrefRangeEnd = 219871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AmbientOneShot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientOneShot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006D1D RID: 27933 RVA: 0x000335B6 File Offset: 0x000317B6
		public AmbientOneShot(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002089 RID: 8329
		// (get) Token: 0x06006D1E RID: 27934 RVA: 0x001E8528 File Offset: 0x001E6728
		// (set) Token: 0x06006D1F RID: 27935 RVA: 0x000335BF File Offset: 0x000317BF
		public unsafe AudioSourceController Audio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr_Audio);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr_Audio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700208A RID: 8330
		// (get) Token: 0x06006D20 RID: 27936 RVA: 0x001E8558 File Offset: 0x001E6758
		// (set) Token: 0x06006D21 RID: 27937 RVA: 0x000335DE File Offset: 0x000317DE
		public unsafe float Volume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr_Volume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr_Volume)) = value;
			}
		}

		// Token: 0x1700208B RID: 8331
		// (get) Token: 0x06006D22 RID: 27938 RVA: 0x001E8580 File Offset: 0x001E6780
		// (set) Token: 0x06006D23 RID: 27939 RVA: 0x000335F9 File Offset: 0x000317F9
		public unsafe float ChancePerHour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr_ChancePerHour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr_ChancePerHour)) = value;
			}
		}

		// Token: 0x1700208C RID: 8332
		// (get) Token: 0x06006D24 RID: 27940 RVA: 0x001E85A8 File Offset: 0x001E67A8
		// (set) Token: 0x06006D25 RID: 27941 RVA: 0x00033614 File Offset: 0x00031814
		public unsafe int CooldownTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr_CooldownTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr_CooldownTime)) = value;
			}
		}

		// Token: 0x1700208D RID: 8333
		// (get) Token: 0x06006D26 RID: 27942 RVA: 0x001E85D0 File Offset: 0x001E67D0
		// (set) Token: 0x06006D27 RID: 27943 RVA: 0x0003362F File Offset: 0x0003182F
		public unsafe AmbientOneShot.EPlayTime PlayTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr_PlayTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr_PlayTime)) = value;
			}
		}

		// Token: 0x1700208E RID: 8334
		// (get) Token: 0x06006D28 RID: 27944 RVA: 0x001E85F8 File Offset: 0x001E67F8
		// (set) Token: 0x06006D29 RID: 27945 RVA: 0x0003364A File Offset: 0x0003184A
		public unsafe float MinDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr_MinDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr_MinDistance)) = value;
			}
		}

		// Token: 0x1700208F RID: 8335
		// (get) Token: 0x06006D2A RID: 27946 RVA: 0x001E8620 File Offset: 0x001E6820
		// (set) Token: 0x06006D2B RID: 27947 RVA: 0x00033665 File Offset: 0x00031865
		public unsafe float MaxDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr_MaxDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr_MaxDistance)) = value;
			}
		}

		// Token: 0x17002090 RID: 8336
		// (get) Token: 0x06006D2C RID: 27948 RVA: 0x001E8648 File Offset: 0x001E6848
		// (set) Token: 0x06006D2D RID: 27949 RVA: 0x00033680 File Offset: 0x00031880
		public unsafe int timeSinceLastPlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr_timeSinceLastPlay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr_timeSinceLastPlay)) = value;
			}
		}

		// Token: 0x04004AA4 RID: 19108
		private static readonly IntPtr NativeFieldInfoPtr_Audio;

		// Token: 0x04004AA5 RID: 19109
		private static readonly IntPtr NativeFieldInfoPtr_Volume;

		// Token: 0x04004AA6 RID: 19110
		private static readonly IntPtr NativeFieldInfoPtr_ChancePerHour;

		// Token: 0x04004AA7 RID: 19111
		private static readonly IntPtr NativeFieldInfoPtr_CooldownTime;

		// Token: 0x04004AA8 RID: 19112
		private static readonly IntPtr NativeFieldInfoPtr_PlayTime;

		// Token: 0x04004AA9 RID: 19113
		private static readonly IntPtr NativeFieldInfoPtr_MinDistance;

		// Token: 0x04004AAA RID: 19114
		private static readonly IntPtr NativeFieldInfoPtr_MaxDistance;

		// Token: 0x04004AAB RID: 19115
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastPlay;

		// Token: 0x04004AAC RID: 19116
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04004AAD RID: 19117
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0;

		// Token: 0x04004AAE RID: 19118
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x04004AAF RID: 19119
		private static readonly IntPtr NativeMethodInfoPtr_Play_Private_Void_0;

		// Token: 0x04004AB0 RID: 19120
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AA5 RID: 2725
		[OriginalName("Assembly-CSharp.dll", "", "EPlayTime")]
		public enum EPlayTime
		{
			// Token: 0x04009031 RID: 36913
			All,
			// Token: 0x04009032 RID: 36914
			Day,
			// Token: 0x04009033 RID: 36915
			Night
		}
	}
}
