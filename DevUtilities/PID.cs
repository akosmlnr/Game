using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000486 RID: 1158
	[System.Serializable]
	public class PID : Il2CppSystem.Object
	{
		// Token: 0x0600637C RID: 25468 RVA: 0x001C7558 File Offset: 0x001C5758
		// Note: this type is marked as 'beforefieldinit'.
		static PID()
		{
			Il2CppClassPointerStore<PID>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "PID");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PID>.NativeClassPtr);
			PID.NativeFieldInfoPtr_pFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PID>.NativeClassPtr, "pFactor");
			PID.NativeFieldInfoPtr_iFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PID>.NativeClassPtr, "iFactor");
			PID.NativeFieldInfoPtr_dFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PID>.NativeClassPtr, "dFactor");
			PID.NativeFieldInfoPtr_integral = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PID>.NativeClassPtr, "integral");
			PID.NativeFieldInfoPtr_lastError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PID>.NativeClassPtr, "lastError");
			PID.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PID>.NativeClassPtr, 100676037);
			PID.NativeMethodInfoPtr_Update_Public_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PID>.NativeClassPtr, 100676038);
		}

		// Token: 0x0600637D RID: 25469 RVA: 0x001C7614 File Offset: 0x001C5814
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 205578, RefRangeEnd = 205580, XrefRangeStart = 205577, XrefRangeEnd = 205578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PID(float pFactor, float iFactor, float dFactor) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PID>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref pFactor;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref iFactor;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref dFactor;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PID.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600637E RID: 25470 RVA: 0x001C7678 File Offset: 0x001C5878
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 205580, RefRangeEnd = 205583, XrefRangeStart = 205580, XrefRangeEnd = 205580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float Update(float setpoint, float actual, float timeFrame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref setpoint;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref actual;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref timeFrame;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PID.NativeMethodInfoPtr_Update_Public_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600637F RID: 25471 RVA: 0x0002EC82 File Offset: 0x0002CE82
		public PID(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001DB8 RID: 7608
		// (get) Token: 0x06006380 RID: 25472 RVA: 0x001C76E0 File Offset: 0x001C58E0
		// (set) Token: 0x06006381 RID: 25473 RVA: 0x0002EC8B File Offset: 0x0002CE8B
		public unsafe float pFactor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PID.NativeFieldInfoPtr_pFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PID.NativeFieldInfoPtr_pFactor)) = value;
			}
		}

		// Token: 0x17001DB9 RID: 7609
		// (get) Token: 0x06006382 RID: 25474 RVA: 0x001C7708 File Offset: 0x001C5908
		// (set) Token: 0x06006383 RID: 25475 RVA: 0x0002ECA6 File Offset: 0x0002CEA6
		public unsafe float iFactor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PID.NativeFieldInfoPtr_iFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PID.NativeFieldInfoPtr_iFactor)) = value;
			}
		}

		// Token: 0x17001DBA RID: 7610
		// (get) Token: 0x06006384 RID: 25476 RVA: 0x001C7730 File Offset: 0x001C5930
		// (set) Token: 0x06006385 RID: 25477 RVA: 0x0002ECC1 File Offset: 0x0002CEC1
		public unsafe float dFactor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PID.NativeFieldInfoPtr_dFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PID.NativeFieldInfoPtr_dFactor)) = value;
			}
		}

		// Token: 0x17001DBB RID: 7611
		// (get) Token: 0x06006386 RID: 25478 RVA: 0x001C7758 File Offset: 0x001C5958
		// (set) Token: 0x06006387 RID: 25479 RVA: 0x0002ECDC File Offset: 0x0002CEDC
		public unsafe float integral
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PID.NativeFieldInfoPtr_integral);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PID.NativeFieldInfoPtr_integral)) = value;
			}
		}

		// Token: 0x17001DBC RID: 7612
		// (get) Token: 0x06006388 RID: 25480 RVA: 0x001C7780 File Offset: 0x001C5980
		// (set) Token: 0x06006389 RID: 25481 RVA: 0x0002ECF7 File Offset: 0x0002CEF7
		public unsafe float lastError
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PID.NativeFieldInfoPtr_lastError);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PID.NativeFieldInfoPtr_lastError)) = value;
			}
		}

		// Token: 0x040043E3 RID: 17379
		private static readonly System.IntPtr NativeFieldInfoPtr_pFactor;

		// Token: 0x040043E4 RID: 17380
		private static readonly System.IntPtr NativeFieldInfoPtr_iFactor;

		// Token: 0x040043E5 RID: 17381
		private static readonly System.IntPtr NativeFieldInfoPtr_dFactor;

		// Token: 0x040043E6 RID: 17382
		private static readonly System.IntPtr NativeFieldInfoPtr_integral;

		// Token: 0x040043E7 RID: 17383
		private static readonly System.IntPtr NativeFieldInfoPtr_lastError;

		// Token: 0x040043E8 RID: 17384
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0;

		// Token: 0x040043E9 RID: 17385
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Single_Single_Single_Single_0;
	}
}
